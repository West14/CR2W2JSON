using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		[Ordinal(1)] [RED("alwaysApplyFullWeaponCharge")] public CBool AlwaysApplyFullWeaponCharge { get; set; }

		public gameEffectObjectFilter_OnlyNearest_Pierce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
