using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryDamageDealt : CVariable
	{
		[Ordinal(0)] [RED("situation")] public CEnum<gameTelemetryDamageSituation> Situation { get; set; }
		[Ordinal(1)] [RED("damage")] public gameTelemetryDamage Damage { get; set; }
		[Ordinal(2)] [RED("enemy")] public gameTelemetryEnemy Enemy { get; set; }

		public gameTelemetryDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
