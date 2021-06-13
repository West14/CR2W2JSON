using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(6)] [RED("owner_id")] public entEntityID Owner_id { get; set; }
		[Ordinal(7)] [RED("statusEffect_armor1_id")] public TweakDBID StatusEffect_armor1_id { get; set; }
		[Ordinal(8)] [RED("statusEffect_armor2_id")] public TweakDBID StatusEffect_armor2_id { get; set; }
		[Ordinal(9)] [RED("statusEffect_armor3_id")] public TweakDBID StatusEffect_armor3_id { get; set; }
		[Ordinal(10)] [RED("statusEffect_smashed_id")] public TweakDBID StatusEffect_smashed_id { get; set; }
		[Ordinal(11)] [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(12)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(13)] [RED("healthListener")] public CHandle<AdamSmasherHealthChangeListener> HealthListener { get; set; }
		[Ordinal(14)] [RED("phase2Threshold")] public CFloat Phase2Threshold { get; set; }
		[Ordinal(15)] [RED("phase3Threshold")] public CFloat Phase3Threshold { get; set; }
		[Ordinal(16)] [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(17)] [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }

		public AdamSmasherComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
