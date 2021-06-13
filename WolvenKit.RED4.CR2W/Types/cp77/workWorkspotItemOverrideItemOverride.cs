using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverrideItemOverride : CVariable
	{
		[Ordinal(0)] [RED("prevItemId")] public TweakDBID PrevItemId { get; set; }
		[Ordinal(1)] [RED("newItemId")] public TweakDBID NewItemId { get; set; }

		public workWorkspotItemOverrideItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
