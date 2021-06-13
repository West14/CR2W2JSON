using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetReactionDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("exitReactionFlag")] public gamebbScriptID_Bool ExitReactionFlag { get; set; }
		[Ordinal(1)] [RED("blockReactionFlag")] public gamebbScriptID_Bool BlockReactionFlag { get; set; }

		public PuppetReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
