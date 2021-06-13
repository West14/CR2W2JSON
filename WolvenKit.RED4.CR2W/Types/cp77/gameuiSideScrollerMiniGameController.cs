using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("gameplayCanvas")] public inkWidgetReference GameplayCanvas { get; set; }
		[Ordinal(3)] [RED("gameName")] public CName GameName { get; set; }

		public gameuiSideScrollerMiniGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
