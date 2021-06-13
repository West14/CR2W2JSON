using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemStatItem : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("labelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(2)] [RED("valueText")] public inkTextWidgetReference ValueText { get; set; }
		[Ordinal(3)] [RED("differenceBarRef")] public inkWidgetReference DifferenceBarRef { get; set; }
		[Ordinal(4)] [RED("diffrenceArrowIndicatorRef")] public inkWidgetReference DiffrenceArrowIndicatorRef { get; set; }
		[Ordinal(5)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(6)] [RED("differenceBar")] public wCHandle<StatisticDifferenceBarController> DifferenceBar { get; set; }
		[Ordinal(7)] [RED("negativeState")] public CName NegativeState { get; set; }
		[Ordinal(8)] [RED("positiveState")] public CName PositiveState { get; set; }

		public InventoryItemStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
