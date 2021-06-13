using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryDamage : CVariable
	{
		[Ordinal(0)] [RED("attackType")] public CEnum<gamedataAttackType> AttackType { get; set; }
		[Ordinal(1)] [RED("damageAmount")] public CFloat DamageAmount { get; set; }
		[Ordinal(2)] [RED("weapon")] public gameTelemetryInventoryItem Weapon { get; set; }
		[Ordinal(3)] [RED("hitCount")] public CUInt32 HitCount { get; set; }
		[Ordinal(4)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(5)] [RED("time")] public CFloat Time { get; set; }

		public gameTelemetryDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
