using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GeometryShape : ISerializable
	{
		[Ordinal(0)] [RED("vertices")] public CArray<Vector3> Vertices { get; set; }
		[Ordinal(1)] [RED("indices")] public CArray<CUInt16> Indices { get; set; }
		[Ordinal(2)] [RED("faces")] public CArray<GeometryShapeFace> Faces { get; set; }

		public GeometryShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
