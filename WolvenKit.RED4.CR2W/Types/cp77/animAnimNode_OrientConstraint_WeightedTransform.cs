using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_OrientConstraint_WeightedTransform : CVariable
	{
		[Ordinal(0)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }

		public animAnimNode_OrientConstraint_WeightedTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
