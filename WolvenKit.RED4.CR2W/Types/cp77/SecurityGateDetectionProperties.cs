using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateDetectionProperties : CVariable
	{
		[Ordinal(0)] [RED("performWeaponCheck")] public CBool PerformWeaponCheck { get; set; }
		[Ordinal(1)] [RED("performCyberwareCheck")] public CBool PerformCyberwareCheck { get; set; }
		[Ordinal(2)] [RED("scannerEntranceType")] public CEnum<ESecurityGateEntranceType> ScannerEntranceType { get; set; }
		[Ordinal(3)] [RED("performCheckOnPlayerOnly")] public CBool PerformCheckOnPlayerOnly { get; set; }

		public SecurityGateDetectionProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
