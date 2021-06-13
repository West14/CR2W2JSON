using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerControlComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(6)] [RED("currentScanEffect")] public CHandle<gameEffectInstance> CurrentScanEffect { get; set; }
		[Ordinal(7)] [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }
		[Ordinal(8)] [RED("scannerTriggerComponentName")] public CName ScannerTriggerComponentName { get; set; }
		[Ordinal(9)] [RED("scannerTriggerComponent")] public CHandle<entIComponent> ScannerTriggerComponent { get; set; }
		[Ordinal(10)] [RED("a")] public CHandle<gameStaticTriggerAreaComponent> A { get; set; }
		[Ordinal(11)] [RED("isScanningPlayer")] public CBool IsScanningPlayer { get; set; }

		public ScannerControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
