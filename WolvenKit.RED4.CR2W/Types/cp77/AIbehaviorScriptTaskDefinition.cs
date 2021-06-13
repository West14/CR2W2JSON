using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("script")] public CHandle<AIbehaviortaskScript> Script { get; set; }
		[Ordinal(2)] [RED("disableLazyInitialization")] public CBool DisableLazyInitialization { get; set; }

		public AIbehaviorScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
