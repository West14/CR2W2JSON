using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_TopbarHubMenuDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("IsSubmenuHidden")] public gamebbScriptID_Bool IsSubmenuHidden { get; set; }
		[Ordinal(1)] [RED("MetaQuestStatus")] public gamebbScriptID_Variant MetaQuestStatus { get; set; }

		public UI_TopbarHubMenuDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
