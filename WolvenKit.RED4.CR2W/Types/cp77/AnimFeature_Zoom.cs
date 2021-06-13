using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Zoom : animAnimFeature
	{
		[Ordinal(0)] [RED("finalZoomLevel")] public CFloat FinalZoomLevel { get; set; }
		[Ordinal(1)] [RED("weaponZoomLevel")] public CFloat WeaponZoomLevel { get; set; }
		[Ordinal(2)] [RED("weaponAimFOV")] public CFloat WeaponAimFOV { get; set; }
		[Ordinal(3)] [RED("worldFOV")] public CFloat WorldFOV { get; set; }
		[Ordinal(4)] [RED("zoomLevelNum")] public CInt32 ZoomLevelNum { get; set; }
		[Ordinal(5)] [RED("noWeaponAimInTime")] public CFloat NoWeaponAimInTime { get; set; }
		[Ordinal(6)] [RED("noWeaponAimOutTime")] public CFloat NoWeaponAimOutTime { get; set; }
		[Ordinal(7)] [RED("shouldUseWeaponZoomStats")] public CBool ShouldUseWeaponZoomStats { get; set; }
		[Ordinal(8)] [RED("focusModeActive")] public CBool FocusModeActive { get; set; }
		[Ordinal(9)] [RED("weaponScopeFov")] public CFloat WeaponScopeFov { get; set; }

		public AnimFeature_Zoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
