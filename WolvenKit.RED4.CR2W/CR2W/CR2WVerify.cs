using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.RED4.CR2W.Types;
using RED.CRC32;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.CR2W
{
    public class CR2WVerify : IDisposable
    {
        #region Fields

        private const uint DEADBEEF = 0xDEADBEEF;
        private const uint MAGIC = 0x57325243;
        private bool isDisposed;
        private CR2WBuffer[] m_buffers;
        private Dictionary<uint, string> m_dictionary;
        private CR2WEmbedded[] m_embedded;
        private CR2WExport[] m_exports;
        private CR2WFileHeader m_fileheader;
        private string m_filePath;
        private bool m_hasInternalBuffer;
        private CR2WImport[] m_imports;
        private CR2WName[] m_names;
        private Stream m_stream;
        private Byte[] m_strings;
        private CR2WProperty[] m_table4;
        private CR2WTable[] m_tableheaders;
        private byte[] m_temp;

        #endregion Fields

        #region Constructor

        internal CR2WVerify(Stream stream, string filePath)
        {
            m_stream = stream;
            m_filePath = filePath;
            m_stream.Seek(0, SeekOrigin.Begin);
            ProcessFile();
        }

        public static void VerifyFile(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            var v = new CR2WVerify(fs, path);
        }

        #endregion Constructor

        #region Destructors

        ~CR2WVerify()
        {
            Dispose(false);
        }

        #endregion Destructors

        #region Main

        private void ProcessFile()
        {
            var id = ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            m_hasInternalBuffer = m_fileheader.buffersEnd > m_fileheader.objectsEnd;
            m_tableheaders = ReadStructs<CR2WTable>(10);

            m_strings = ReadStringsBuffer();
            m_names = ReadTable<CR2WName>(1);
            m_imports = ReadTable<CR2WImport>(2);
            m_table4 = ReadTable<CR2WProperty>(3);
            m_exports = ReadTable<CR2WExport>(4);
            m_buffers = ReadTable<CR2WBuffer>(5);
            m_embedded = ReadTable<CR2WEmbedded>(6);

            // Fixing
            for (int i = 0; i < m_names.Length; i++)
                FixNameFNV1A(ref m_names[i]);

            for (int i = 0; i < m_exports.Length; i++)
                FixExportCRC32(ref m_exports[i]);

            for (int i = 0; i < m_buffers.Length; i++)
                FixBufferCRC32(ref m_buffers[i]);

            // Write File
            m_stream.Seek(160, SeekOrigin.Begin);

            WriteStringBuffer();
            WriteTable<CR2WName>(m_names, 1);
            WriteTable<CR2WImport>(m_imports, 2);
            WriteTable<CR2WProperty>(m_table4, 3);
            WriteTable<CR2WExport>(m_exports, 4);
            WriteTable<CR2WBuffer>(m_buffers, 5);
            WriteTable<CR2WEmbedded>(m_embedded, 6);

            // Write Header again
            m_stream.Seek(0, SeekOrigin.Begin);

            m_fileheader.timeStamp = CDateTime.Now.ToUInt64();
            m_fileheader.crc32 = CalculateHeaderCRC32();

            WriteStruct<uint>(MAGIC);
            WriteStruct<CR2WFileHeader>(m_fileheader);
            WriteStructs<CR2WTable>(m_tableheaders);
        }

        #endregion Main

        #region Table Reading

        private byte[] ReadStringsBuffer()
        {
            var start = m_tableheaders[0].offset;
            var size = m_tableheaders[0].itemCount;
            var crc = m_tableheaders[0].crc32;

            m_temp = new byte[size];
            m_stream.Read(m_temp, 0, m_temp.Length);

            m_dictionary = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            uint offset = 0;
            for (uint i = 0; i < size; i++)
            {
                var b = m_temp[i];
                if (b == 0)
                {
                    m_dictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                }
            }

            return m_temp;
        }

        private T[] ReadTable<T>(int index) where T : struct
        {
            m_stream.Seek(m_tableheaders[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = ReadStructs<T>(m_tableheaders[index].itemCount, hash);

            return table;
        }

        private void WriteStringBuffer()
        {
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);
            m_stream.Write(m_strings, 0, m_strings.Length);
        }

        private void WriteTable<T>(T[] array, int index) where T : struct
        {
            if (array.Length == 0)
                return;

            var crc = new Crc32Algorithm(false);
            WriteStructs<T>(array, crc);
            m_tableheaders[index].crc32 = crc.HashUInt32;
        }

        #endregion Table Reading

        #region Hashing

        private uint CalculateHeaderCRC32()
        {
            var hash = new Crc32Algorithm(false);
            hash.Append(BitConverter.GetBytes(MAGIC));
            hash.Append(BitConverter.GetBytes(m_fileheader.version));
            hash.Append(BitConverter.GetBytes(m_fileheader.flags));
            hash.Append(BitConverter.GetBytes(m_fileheader.timeStamp));
            hash.Append(BitConverter.GetBytes(m_fileheader.buildVersion));
            hash.Append(BitConverter.GetBytes(m_fileheader.objectsEnd));
            hash.Append(BitConverter.GetBytes(m_fileheader.buffersEnd));
            hash.Append(BitConverter.GetBytes(DEADBEEF));
            hash.Append(BitConverter.GetBytes(m_fileheader.numChunks));
            foreach (var h in m_tableheaders)
            {
                hash.Append(BitConverter.GetBytes(h.offset));
                hash.Append(BitConverter.GetBytes(h.itemCount));
                hash.Append(BitConverter.GetBytes(h.crc32));
            }
            return hash.HashUInt32;
        }

        private void FixBufferCRC32(ref CR2WBuffer buffer)
        {
            //This might throw errors, the way it should be checked for is by reading
            //the object tree to find the deferred data buffers that will point to a buffer.
            //The flag of the parent object indicates where to read the data from.
            //For now this is a crude workaround.
            if (m_hasInternalBuffer)
            {
                m_stream.Seek(buffer.offset, SeekOrigin.Begin);
                m_temp = new byte[buffer.diskSize];
                m_stream.Read(m_temp, 0, m_temp.Length);
                buffer.crc32 = Crc32Algorithm.Compute(m_temp);
            }
            else
            {
                var path = String.Format("{0}.{1}.buffer", m_filePath, buffer.index);
                if (!File.Exists(path))
                {
                    return;
                }
                m_temp = File.ReadAllBytes(path);
                buffer.crc32 = Crc32Algorithm.Compute(m_temp);
            }
        }

        private void FixExportCRC32(ref CR2WExport export)
        {
            m_stream.Seek(export.dataOffset, SeekOrigin.Begin);
            m_temp = new byte[export.dataSize];
            m_stream.Read(m_temp, 0, m_temp.Length);
            export.crc32 = Crc32Algorithm.Compute(m_temp);
        }

        private void FixNameFNV1A(ref CR2WName name)
        {
            var str = m_dictionary[name.value];
            var hash = FNV1A32HashAlgorithm.HashString(str, Encoding.ASCII, true);
            name.hash = hash;
        }

        #endregion Hashing

        #region Supporting Functions

        private T ReadStruct<T>(Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();

            m_temp = new byte[size];
            m_stream.Read(m_temp, 0, size);

            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
            var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

            if (crc32 != null)
                crc32.Append(m_temp);

            handle.Free();

            return item;
        }

        private T[] ReadStructs<T>(uint count, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];

            m_temp = new byte[size];
            for (uint i = 0; i < count; i++)
            {
                m_stream.Read(m_temp, 0, size);

                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }

            return items;
        }

        private void WriteStruct<T>(T value, Crc32Algorithm crc32 = null) where T : struct
        {
            m_temp = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(m_temp, 0, m_temp.Length);

            if (crc32 != null)
                crc32.Append(m_temp);

            handle.Free();
        }

        private void WriteStructs<T>(T[] array, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            m_temp = new byte[size];
            for (int i = 0; i < array.Length; i++)
            {
                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(m_temp, 0, m_temp.Length);

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }
        }

        #endregion Supporting Functions

        #region Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
                return;

            if (disposing)
            {
                m_stream.Dispose();
            }

            m_strings = null;
            m_names = null;
            m_imports = null;
            m_table4 = null;
            m_exports = null;
            m_buffers = null;
            m_embedded = null;
            m_temp = null;

            isDisposed = true;
        }

        #endregion Methods
    }
}
