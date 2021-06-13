using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CodexSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("CodexUpdated")] public gamebbScriptID_Variant CodexUpdated { get; set; }

		public UI_CodexSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
