using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeSlotData : animAnimFeature
	{
		[Ordinal(0)] [RED("attackType")] public CInt32 AttackType { get; set; }
		[Ordinal(1)] [RED("comboNumber")] public CInt32 ComboNumber { get; set; }
		[Ordinal(2)] [RED("startupDuration")] public CFloat StartupDuration { get; set; }
		[Ordinal(3)] [RED("activeDuration")] public CFloat ActiveDuration { get; set; }
		[Ordinal(4)] [RED("recoverDuration")] public CFloat RecoverDuration { get; set; }
		[Ordinal(5)] [RED("activeHitDuration")] public CFloat ActiveHitDuration { get; set; }
		[Ordinal(6)] [RED("recoverHitDuration")] public CFloat RecoverHitDuration { get; set; }

		public animAnimFeature_MeleeSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
