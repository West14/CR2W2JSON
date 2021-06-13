using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDeathReactionsTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("fastForwardAnimation")] public CHandle<AIArgumentMapping> FastForwardAnimation { get; set; }
		[Ordinal(1)] [RED("hitData")] public CHandle<animAnimFeature_HitReactionsData> HitData { get; set; }
		[Ordinal(2)] [RED("hitReactionAction")] public CHandle<ActionHitReactionScriptProxy> HitReactionAction { get; set; }

		public AIDeathReactionsTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
