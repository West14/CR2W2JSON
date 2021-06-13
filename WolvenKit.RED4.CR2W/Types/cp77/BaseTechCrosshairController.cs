using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseTechCrosshairController : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(19)] [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(20)] [RED("fullChargeAvailable")] public CBool FullChargeAvailable { get; set; }
		[Ordinal(21)] [RED("overChargeAvailable")] public CBool OverChargeAvailable { get; set; }
		[Ordinal(22)] [RED("fullChargeListener")] public CHandle<CrosshairWeaponStatsListener> FullChargeListener { get; set; }
		[Ordinal(23)] [RED("overChargeListener")] public CHandle<CrosshairWeaponStatsListener> OverChargeListener { get; set; }

		public BaseTechCrosshairController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
