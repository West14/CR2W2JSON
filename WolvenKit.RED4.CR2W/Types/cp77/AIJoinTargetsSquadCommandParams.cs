using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIJoinTargetsSquadCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIJoinTargetsSquadCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
