using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)] [RED("chargeModeAim")] public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim { get; set; }
		[Ordinal(1)] [RED("leftHandObject")] public wCHandle<gameweaponObject> LeftHandObject { get; set; }

		public LeftHandCyberwareChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
