using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("MainViewRoot")] public inkWidgetReference MainViewRoot { get; set; }
		[Ordinal(4)] [RED("statsList")] public inkCompoundWidgetReference StatsList { get; set; }
		[Ordinal(5)] [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(6)] [RED("levelControllerRef")] public inkWidgetReference LevelControllerRef { get; set; }
		[Ordinal(7)] [RED("streetCredControllerRef")] public inkWidgetReference StreetCredControllerRef { get; set; }
		[Ordinal(8)] [RED("detailListControllerRef")] public inkWidgetReference DetailListControllerRef { get; set; }
		[Ordinal(9)] [RED("statsStreetCredRewardRef")] public inkWidgetReference StatsStreetCredRewardRef { get; set; }
		[Ordinal(10)] [RED("statsPlayTimeControllerdRef")] public inkWidgetReference StatsPlayTimeControllerdRef { get; set; }
		[Ordinal(11)] [RED("btnInventory")] public inkWidgetReference BtnInventory { get; set; }
		[Ordinal(12)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(13)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(14)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(15)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(16)] [RED("healthStatsData")] public CArray<gameStatViewData> HealthStatsData { get; set; }
		[Ordinal(17)] [RED("DPSStatsData")] public CArray<gameStatViewData> DPSStatsData { get; set; }
		[Ordinal(18)] [RED("armorStatsData")] public CArray<gameStatViewData> ArmorStatsData { get; set; }
		[Ordinal(19)] [RED("otherStatsData")] public CArray<gameStatViewData> OtherStatsData { get; set; }
		[Ordinal(20)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(21)] [RED("currencyListener")] public CUInt32 CurrencyListener { get; set; }
		[Ordinal(22)] [RED("characterCredListener")] public CUInt32 CharacterCredListener { get; set; }
		[Ordinal(23)] [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(24)] [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(25)] [RED("characterCredPointsListener")] public CUInt32 CharacterCredPointsListener { get; set; }
		[Ordinal(26)] [RED("PDS")] public CHandle<PlayerDevelopmentSystem> PDS { get; set; }
		[Ordinal(27)] [RED("levelController")] public CHandle<StatsProgressController> LevelController { get; set; }
		[Ordinal(28)] [RED("streetCredController")] public CHandle<StatsProgressController> StreetCredController { get; set; }
		[Ordinal(29)] [RED("detailListController")] public CHandle<StatsDetailListController> DetailListController { get; set; }
		[Ordinal(30)] [RED("statsStreetCredReward")] public CHandle<StatsStreetCredReward> StatsStreetCredReward { get; set; }
		[Ordinal(31)] [RED("statsPlayTimeController")] public CHandle<StatsPlayTimeController> StatsPlayTimeController { get; set; }
		[Ordinal(32)] [RED("previousMenuData")] public CHandle<PreviousMenuData> PreviousMenuData { get; set; }
		[Ordinal(33)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }

		public StatsMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
