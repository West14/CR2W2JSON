using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMultipleParentConstraint_JsonProperties : ISerializable
	{
		[Ordinal(0)] [RED("parentsTransforms")] public CArray<animMultipleParentConstraint_JsonEntry> ParentsTransforms { get; set; }
		[Ordinal(1)] [RED("transformIndex")] public CName TransformIndex { get; set; }
		[Ordinal(2)] [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }
		[Ordinal(3)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(4)] [RED("weightFloatTrack")] public CName WeightFloatTrack { get; set; }

		public animMultipleParentConstraint_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
