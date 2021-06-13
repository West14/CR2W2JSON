using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Model.Cr2w
{
    #region cr2w

    public interface ICR2WImport
    {
        public uint DepotPath { get; }
        public ushort ClassName { get; }
        public ushort Flags { get; }

        public string DepotPathStr { get; }
        public string ClassNameStr { get; }
    }
    public interface ICR2WBuffer
    {
        public uint Flags { get; }
        public uint Index { get; }
        public uint Offset { get; set; }
        public uint DiskSize { get; set; }
        public uint MemSize { get; set; }
        public uint Crc32 { get; set; }


        public void ReadData(BinaryReader file);
        public void WriteData(BinaryWriter file);
        public void SetOffset(uint offset);
    }
    public interface ICR2WEmbedded
    {

    }
    public interface ICR2WExport
    {
        public IEditableVariable data { get; }
        public string REDType { get; }
        public string REDName { get; }

        public IEditableVariable unknownBytes { get; }

        public ICR2WExport ParentChunk { get; set; }
        public ICR2WExport VirtualParentChunk { get; set; }
        public List<ICR2WExport> ChildrenChunks { get; }
        public List<ICR2WExport> VirtualChildrenChunks { get; }
        public List<IChunkPtrAccessor> AdReferences { get; }
        public List<IChunkPtrAccessor> AbReferences { get; }
        public List<string> UnknownTypes { get; }

        public int ChunkIndex { get; }

        public void CreateDefaultData(IEditableVariable cvar = null);
        public string GetFullChunkTypeDependencyString();
        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false);
        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false);

        public void ReadData(BinaryReader file);
        public void WriteData(BinaryWriter file);
    }

    #endregion

    #region REDtypes

    #region editor interfaces

    public interface IEditorBindable
    {
        [JsonIgnore] [Browsable(false)] IWolvenkitFile Cr2wFile { get; set; }

        [JsonIgnore] [Browsable(false)] bool IsSerialized { get; set; }
    }
    public interface IEditorBindable<T> : IEditorBindable
    {
        public T Value { get; set; } // ???
    }

    #endregion

    #region red primitives

    public interface IREDPrimitive : IEditableVariable { }

    public interface IREDColor : IEditorBindable<Color> { }

    public interface IREDIntegerType<T> : IREDPrimitive, IEditorBindable<T> { }
    public interface IREDString : IREDPrimitive, IEditorBindable<string> { }
    public interface IREDBool : IREDPrimitive, IEditorBindable<bool> { }

    public interface IEnumAccessor : IEditorBindable
    {
        List<string> EnumValueList { get; set; }
        bool IsFlag { get; }

        string GetAttributeVal();
    }

    public interface IEnumAccessor<T> : IEditorBindable<T>, IEnumAccessor where T : Enum
    {
        string EnumToString();
        IEditableVariable SetValue(object val);
        Type GetEnumType();
    }

    #endregion

    public interface IArrayAccessor : IEditableVariable, IList
    {
        List<int> Flags { get; set; }

        string Elementtype { get; set; }
        Type InnerType { get; }
    }

    public interface IArrayAccessor<T> : IArrayAccessor
    {
        List<T> Elements { get; set; }
    }

    public interface IBufferAccessor : IArrayAccessor { }

    public interface IVariantAccessor
    {
        IEditableVariable Variant { get; set; }
    }

    public interface IBufferVariantAccessor : IVariantAccessor { }

    public interface IChunkPtrAccessor : IEditableVariable
    {
        ICR2WExport Reference { get; set; }
        string ReferenceType { get; }
    }

    public interface IHandleAccessor : IChunkPtrAccessor
    {
        bool ChunkHandle { get; set; }
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        void ChangeHandleType();
        public IEnumerable<ICR2WExport> GetReferenceChunks();
    }

    #endregion

}
