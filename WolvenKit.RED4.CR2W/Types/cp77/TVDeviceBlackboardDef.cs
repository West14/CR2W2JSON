using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("PreviousChannel")] public gamebbScriptID_Int32 PreviousChannel { get; set; }
		[Ordinal(8)] [RED("CurrentChannel")] public gamebbScriptID_Int32 CurrentChannel { get; set; }

		public TVDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
