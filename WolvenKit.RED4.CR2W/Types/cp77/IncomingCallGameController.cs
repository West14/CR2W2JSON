using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncomingCallGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("contactNameWidget")] public inkTextWidgetReference ContactNameWidget { get; set; }
		[Ordinal(10)] [RED("phoneBlackboard")] public wCHandle<gameIBlackboard> PhoneBlackboard { get; set; }
		[Ordinal(11)] [RED("phoneBBDefinition")] public CHandle<UI_ComDeviceDef> PhoneBBDefinition { get; set; }
		[Ordinal(12)] [RED("phoneCallInfoBBID")] public CUInt32 PhoneCallInfoBBID { get; set; }
		[Ordinal(13)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(14)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public IncomingCallGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
