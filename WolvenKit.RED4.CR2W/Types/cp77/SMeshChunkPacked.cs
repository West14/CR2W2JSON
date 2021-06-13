using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshChunkPacked : CVariable
	{
		[Ordinal(0)] [RED("vertexType")] public CEnum<EMeshVertexType> VertexType { get; set; }
		[Ordinal(1)] [RED("materialID")] public CArray<CName> MaterialID { get; set; }
		[Ordinal(2)] [RED("numBonesPerVertex")] public CUInt8 NumBonesPerVertex { get; set; }
		[Ordinal(3)] [RED("numVertices")] public CUInt32 NumVertices { get; set; }
		[Ordinal(4)] [RED("numIndices")] public CUInt32 NumIndices { get; set; }
		[Ordinal(5)] [RED("firstVertex")] public CUInt32 FirstVertex { get; set; }
		[Ordinal(6)] [RED("firstIndex")] public CUInt32 FirstIndex { get; set; }
		[Ordinal(7)] [RED("renderMask")] public CEnum<EMeshChunkRenderMask> RenderMask { get; set; }
		[Ordinal(8)] [RED("chunkRenderMask")] public CEnum<EMeshChunkFlags> ChunkRenderMask { get; set; }
		[Ordinal(9)] [RED("useForShadowmesh")] public CBool UseForShadowmesh { get; set; }
		[Ordinal(10)] [RED("streams")] public CArray<SMeshStream> Streams { get; set; }
		[Ordinal(11)] [RED("streamMask")] public CUInt64 StreamMask { get; set; }
		[Ordinal(12)] [RED("lodMask")] public CUInt8 LodMask { get; set; }

		public SMeshChunkPacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
