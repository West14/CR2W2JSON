using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayBinkDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("bink")] public SBinkperationData Bink { get; set; }

		public PlayBinkDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
