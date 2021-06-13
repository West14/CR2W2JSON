using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePersonalLink : ActionBool
	{
		[Ordinal(25)] [RED("cachedStatus")] public CEnum<EPersonalLinkConnectionStatus> CachedStatus { get; set; }
		[Ordinal(26)] [RED("shouldSkipMiniGame")] public CBool ShouldSkipMiniGame { get; set; }

		public TogglePersonalLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
