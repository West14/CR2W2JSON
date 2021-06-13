using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayChoiceOption : CVariable
	{
		[Ordinal(0)] [RED("itemId")] public scnscreenplayItemId ItemId { get; set; }
		[Ordinal(1)] [RED("usage")] public scnscreenplayOptionUsage Usage { get; set; }
		[Ordinal(2)] [RED("locstringId")] public scnlocLocstringId LocstringId { get; set; }

		public scnscreenplayChoiceOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
