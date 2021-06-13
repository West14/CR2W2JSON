using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamUICollisionData : meshMeshParameter
	{
		[Ordinal(0)] [RED("uvs")] public CArray<Vector2> Uvs { get; set; }
		[Ordinal(1)] [RED("trianglesIndices")] public CArray<CUInt16> TrianglesIndices { get; set; }
		[Ordinal(2)] [RED("vertices")] public CArray<Vector3> Vertices { get; set; }

		public meshMeshParamUICollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
