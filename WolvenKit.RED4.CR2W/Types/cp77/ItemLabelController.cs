using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLabelController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)] [RED("moneyIcon")] public inkImageWidgetReference MoneyIcon { get; set; }
		[Ordinal(3)] [RED("type")] public CEnum<ItemLabelType> Type { get; set; }

		public ItemLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
