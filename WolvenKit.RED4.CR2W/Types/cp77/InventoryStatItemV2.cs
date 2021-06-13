using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItemV2 : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("LabelRef")] public inkTextWidgetReference LabelRef { get; set; }
		[Ordinal(2)] [RED("ValueRef")] public inkTextWidgetReference ValueRef { get; set; }
		[Ordinal(3)] [RED("Icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(4)] [RED("BackgroundIcon")] public inkImageWidgetReference BackgroundIcon { get; set; }
		[Ordinal(5)] [RED("TextGroup")] public inkWidgetReference TextGroup { get; set; }
		[Ordinal(6)] [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }

		public InventoryStatItemV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
