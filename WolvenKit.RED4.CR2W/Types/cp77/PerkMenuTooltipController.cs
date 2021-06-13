using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkMenuTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] [RED("titleContainer")] public inkWidgetReference TitleContainer { get; set; }
		[Ordinal(3)] [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(4)] [RED("typeContainer")] public inkWidgetReference TypeContainer { get; set; }
		[Ordinal(5)] [RED("typeText")] public inkTextWidgetReference TypeText { get; set; }
		[Ordinal(6)] [RED("desc1Container")] public inkWidgetReference Desc1Container { get; set; }
		[Ordinal(7)] [RED("desc1Text")] public inkTextWidgetReference Desc1Text { get; set; }
		[Ordinal(8)] [RED("desc2Container")] public inkWidgetReference Desc2Container { get; set; }
		[Ordinal(9)] [RED("desc2Text")] public inkTextWidgetReference Desc2Text { get; set; }
		[Ordinal(10)] [RED("desc2TextNextLevel")] public inkTextWidgetReference Desc2TextNextLevel { get; set; }
		[Ordinal(11)] [RED("desc2TextNextLevelDesc")] public inkTextWidgetReference Desc2TextNextLevelDesc { get; set; }
		[Ordinal(12)] [RED("holdToUpgrade")] public inkWidgetReference HoldToUpgrade { get; set; }
		[Ordinal(13)] [RED("openPerkScreen")] public inkWidgetReference OpenPerkScreen { get; set; }
		[Ordinal(14)] [RED("videoContainerWidget")] public inkWidgetReference VideoContainerWidget { get; set; }
		[Ordinal(15)] [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(16)] [RED("data")] public CHandle<BasePerksMenuTooltipData> Data { get; set; }
		[Ordinal(17)] [RED("maxProficiencyLevel")] public CInt32 MaxProficiencyLevel { get; set; }

		public PerkMenuTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
