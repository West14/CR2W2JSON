using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(19)] [RED("weaponBBID")] public CUInt32 WeaponBBID { get; set; }
		[Ordinal(20)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(21)] [RED("Cori_S")] public inkCanvasWidgetReference Cori_S { get; set; }
		[Ordinal(22)] [RED("Cori_M")] public inkCanvasWidgetReference Cori_M { get; set; }
		[Ordinal(23)] [RED("rightStickX")] public CFloat RightStickX { get; set; }
		[Ordinal(24)] [RED("rightStickY")] public CFloat RightStickY { get; set; }

		public CrosshairGameController_Launcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
