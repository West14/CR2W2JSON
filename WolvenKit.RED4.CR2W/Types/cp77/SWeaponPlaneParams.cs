using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWeaponPlaneParams : CVariable
	{
		[Ordinal(0)] [RED("weaponNearPlaneCM")] public CFloat WeaponNearPlaneCM { get; set; }
		[Ordinal(1)] [RED("blurIntensity")] public CFloat BlurIntensity { get; set; }

		public SWeaponPlaneParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
