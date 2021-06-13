using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionChunkIndicesOffsets : meshMeshParameter
	{
		[Ordinal(0)] [RED("offsets")] public CArray<meshChunkIndicesOffset> Offsets { get; set; }
		[Ordinal(1)] [RED("chunkOffsets")] public CArray<CUInt32> ChunkOffsets { get; set; }
		[Ordinal(2)] [RED("indices")] public CArray<DataBuffer> Indices { get; set; }

		public meshMeshParamDestructionChunkIndicesOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
