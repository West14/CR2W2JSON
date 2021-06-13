using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapEncodedShapes : CResource
	{
		[Ordinal(1)] [RED("Buffer")] public DataBuffer Buffer { get; set; }
		[Ordinal(2)] [RED("QuantizationScale")] public Vector2 QuantizationScale { get; set; }
		[Ordinal(3)] [RED("QuantizationBias")] public Vector2 QuantizationBias { get; set; }
		[Ordinal(4)] [RED("BoxQuantizationScale")] public Vector3 BoxQuantizationScale { get; set; }
		[Ordinal(5)] [RED("BoxQuantizationBias")] public Vector3 BoxQuantizationBias { get; set; }
		[Ordinal(6)] [RED("NumPoints")] public CUInt32 NumPoints { get; set; }
		[Ordinal(7)] [RED("NumBorderPoints")] public CUInt32 NumBorderPoints { get; set; }
		[Ordinal(8)] [RED("NumFillPoints")] public CUInt32 NumFillPoints { get; set; }
		[Ordinal(9)] [RED("NumShapes")] public CUInt32 NumShapes { get; set; }
		[Ordinal(10)] [RED("NumSpatialBuckets")] public CUInt32 NumSpatialBuckets { get; set; }
		[Ordinal(11)] [RED("NumUniqueGeometry")] public CUInt32 NumUniqueGeometry { get; set; }
		[Ordinal(12)] [RED("NumOwners")] public CUInt32 NumOwners { get; set; }
		[Ordinal(13)] [RED("Version")] public CUInt32 Version { get; set; }

		public minimapEncodedShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
