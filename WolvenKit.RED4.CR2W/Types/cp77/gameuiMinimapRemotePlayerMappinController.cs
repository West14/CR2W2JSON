using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] [RED("rootWidget")] public inkWidgetReference RootWidget { get; set; }
		[Ordinal(15)] [RED("shapeWidget")] public inkWidgetReference ShapeWidget { get; set; }
		[Ordinal(16)] [RED("dataWidget")] public inkWidgetReference DataWidget { get; set; }
		[Ordinal(17)] [RED("playerMappin")] public wCHandle<gamemappinsRemotePlayerMappin> PlayerMappin { get; set; }

		public gameuiMinimapRemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
