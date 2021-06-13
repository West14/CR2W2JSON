using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("AbilityIcon")] public inkImageWidgetReference AbilityIcon { get; set; }
		[Ordinal(2)] [RED("AbilityDescription")] public inkTextWidgetReference AbilityDescription { get; set; }
		[Ordinal(3)] [RED("QualityRoot")] public inkWidgetReference QualityRoot { get; set; }

		public TooltipSpecialAbilityDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
