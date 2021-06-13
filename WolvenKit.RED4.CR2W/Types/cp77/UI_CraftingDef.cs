using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CraftingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("lastCommand")] public gamebbScriptID_Variant LastCommand { get; set; }
		[Ordinal(1)] [RED("lastItem")] public gamebbScriptID_Variant LastItem { get; set; }
		[Ordinal(2)] [RED("lastIngredients")] public gamebbScriptID_Variant LastIngredients { get; set; }

		public UI_CraftingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
