using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(13)] [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(14)] [RED("limitOnXAxis")] public animFloatClamp LimitOnXAxis { get; set; }
		[Ordinal(15)] [RED("limitOnYAxis")] public animFloatClamp LimitOnYAxis { get; set; }
		[Ordinal(16)] [RED("limitOnZAxis")] public animFloatClamp LimitOnZAxis { get; set; }

		public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
