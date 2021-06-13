using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryDescriptionQuery : IScriptable
	{
		[Ordinal(0)] [RED("refPosition")] public Vector4 RefPosition { get; set; }
		[Ordinal(1)] [RED("refDirection")] public Vector4 RefDirection { get; set; }
		[Ordinal(2)] [RED("refUp")] public Vector4 RefUp { get; set; }
		[Ordinal(3)] [RED("primitiveDimension")] public Vector4 PrimitiveDimension { get; set; }
		[Ordinal(4)] [RED("primitiveRotation")] public Quaternion PrimitiveRotation { get; set; }
		[Ordinal(5)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(6)] [RED("maxExtent")] public CFloat MaxExtent { get; set; }
		[Ordinal(7)] [RED("raycastStartDistance")] public CFloat RaycastStartDistance { get; set; }
		[Ordinal(8)] [RED("probingPrecision")] public CFloat ProbingPrecision { get; set; }
		[Ordinal(9)] [RED("probingMaxDistanceDiff")] public CFloat ProbingMaxDistanceDiff { get; set; }
		[Ordinal(10)] [RED("maxProbes")] public CUInt32 MaxProbes { get; set; }
		[Ordinal(11)] [RED("probeDimensions")] public Vector4 ProbeDimensions { get; set; }
		[Ordinal(12)] [RED("filter")] public physicsQueryFilter Filter { get; set; }
		[Ordinal(13)] [RED("flags")] public CUInt32 Flags { get; set; }

		public worldgeometryDescriptionQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
