using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionNode : worldNode
	{
		[Ordinal(4)] [RED("compiledData")] public DataBuffer CompiledData { get; set; }
		[Ordinal(5)] [RED("numActors")] public CUInt16 NumActors { get; set; }
		[Ordinal(6)] [RED("numShapeInfos")] public CUInt16 NumShapeInfos { get; set; }
		[Ordinal(7)] [RED("numShapePositions")] public CUInt16 NumShapePositions { get; set; }
		[Ordinal(8)] [RED("numShapeRotations")] public CUInt16 NumShapeRotations { get; set; }
		[Ordinal(9)] [RED("numScales")] public CUInt16 NumScales { get; set; }
		[Ordinal(10)] [RED("numMaterials")] public CUInt16 NumMaterials { get; set; }
		[Ordinal(11)] [RED("numPresets")] public CUInt16 NumPresets { get; set; }
		[Ordinal(12)] [RED("numMaterialIndices")] public CUInt16 NumMaterialIndices { get; set; }
		[Ordinal(13)] [RED("numShapeIndices")] public CUInt16 NumShapeIndices { get; set; }
		[Ordinal(14)] [RED("sectorHash")] public CUInt64 SectorHash { get; set; }
		[Ordinal(15)] [RED("extents")] public Vector4 Extents { get; set; }
		[Ordinal(16)] [RED("lod")] public CUInt8 Lod { get; set; }
		[Ordinal(17)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

		public worldCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
