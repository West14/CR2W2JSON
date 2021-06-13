using System.IO;

namespace WolvenKit.RED4.CR2W
{
    public class CR2WHeaderData
    {
        #region Fields

        public uint crc;
        public uint offset;
        public uint size;

        #endregion Fields

        #region Constructors

        public CR2WHeaderData()
        {
        }

        public CR2WHeaderData(BinaryReader file)
        {
            Read(file);
        }

        #endregion Constructors

        #region Methods

        public void Read(BinaryReader file)
        {
            offset = file.ReadUInt32();
            size = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            if (size == 0)
            {
                offset = 0;
                crc = 0;
            }

            file.Write(offset);
            file.Write(size);
            file.Write(crc);
        }

        #endregion Methods
    }
}
