using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationNavigationBtn : inkButtonController
	{
		[Ordinal(10)] [RED("icon1")] public inkWidgetReference Icon1 { get; set; }
		[Ordinal(11)] [RED("shouldPlaySoundOnHover")] public CBool ShouldPlaySoundOnHover { get; set; }
		[Ordinal(12)] [RED("root")] public CHandle<inkWidget> Root { get; set; }

		public characterCreationNavigationBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
