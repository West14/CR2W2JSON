using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionParams : CVariable
	{
		[Ordinal(0)] [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(1)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(2)] [RED("markEdgeChunks")] public CBool MarkEdgeChunks { get; set; }
		[Ordinal(3)] [RED("useAggregatesForClusters")] public CBool UseAggregatesForClusters { get; set; }
		[Ordinal(4)] [RED("turnDynamicOnImpulse")] public CBool TurnDynamicOnImpulse { get; set; }
		[Ordinal(5)] [RED("buildConvexForClusters")] public CBool BuildConvexForClusters { get; set; }
		[Ordinal(6)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(7)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(8)] [RED("bondEndurance")] public CFloat BondEndurance { get; set; }
		[Ordinal(9)] [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(10)] [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(11)] [RED("contactToDamage")] public CFloat ContactToDamage { get; set; }
		[Ordinal(12)] [RED("maxContactImpulseRatio")] public CFloat MaxContactImpulseRatio { get; set; }
		[Ordinal(13)] [RED("impulseChildPropagationFactor")] public CFloat ImpulseChildPropagationFactor { get; set; }
		[Ordinal(14)] [RED("impulsePropagationFactor")] public CFloat ImpulsePropagationFactor { get; set; }
		[Ordinal(15)] [RED("impulseDiminishingFactor")] public CFloat ImpulseDiminishingFactor { get; set; }
		[Ordinal(16)] [RED("breakBonds")] public CBool BreakBonds { get; set; }
		[Ordinal(17)] [RED("debrisTimeout")] public CBool DebrisTimeout { get; set; }
		[Ordinal(18)] [RED("debrisTimeoutMin")] public CFloat DebrisTimeoutMin { get; set; }
		[Ordinal(19)] [RED("debrisTimeoutMax")] public CFloat DebrisTimeoutMax { get; set; }
		[Ordinal(20)] [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(21)] [RED("debrisMaxSeparation")] public CFloat DebrisMaxSeparation { get; set; }
		[Ordinal(22)] [RED("visualsRemain")] public CBool VisualsRemain { get; set; }
		[Ordinal(23)] [RED("debrisDestructible")] public CBool DebrisDestructible { get; set; }
		[Ordinal(24)] [RED("supportDamage")] public CBool SupportDamage { get; set; }
		[Ordinal(25)] [RED("maxAngularVelocity")] public CFloat MaxAngularVelocity { get; set; }

		public physicsDestructionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
