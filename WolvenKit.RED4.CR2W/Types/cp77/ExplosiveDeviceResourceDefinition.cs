using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceResourceDefinition : CVariable
	{
		[Ordinal(0)] [RED("damageType")] public TweakDBID DamageType { get; set; }
		[Ordinal(1)] [RED("vfxResource")] public gameFxResource VfxResource { get; set; }
		[Ordinal(2)] [RED("vfxEventNamesOnExplosion")] public CArray<CName> VfxEventNamesOnExplosion { get; set; }
		[Ordinal(3)] [RED("vfxResourceOnFirstHit")] public CArray<gameFxResource> VfxResourceOnFirstHit { get; set; }
		[Ordinal(4)] [RED("executionDelay")] public CFloat ExecutionDelay { get; set; }
		[Ordinal(5)] [RED("additionalGameEffectType")] public CEnum<EExplosiveAdditionalGameEffectType> AdditionalGameEffectType { get; set; }
		[Ordinal(6)] [RED("dontHighlightOnLookat")] public CBool DontHighlightOnLookat { get; set; }

		public ExplosiveDeviceResourceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
