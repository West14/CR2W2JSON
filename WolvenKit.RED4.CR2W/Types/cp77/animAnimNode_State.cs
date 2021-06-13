using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_State : animAnimNode_Container
	{
		[Ordinal(12)] [RED("name")] public CName Name { get; set; }
		[Ordinal(13)] [RED("outTransitionIndices")] public CArray<CInt16> OutTransitionIndices { get; set; }
		[Ordinal(14)] [RED("preventTransitionsInActivationFrame")] public CBool PreventTransitionsInActivationFrame { get; set; }
		[Ordinal(15)] [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(16)] [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }

		public animAnimNode_State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
