using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buildsWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("horizontalPanelsList")] public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList { get; set; }

		public buildsWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
