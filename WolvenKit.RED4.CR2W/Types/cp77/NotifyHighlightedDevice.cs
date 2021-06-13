using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyHighlightedDevice : redEvent
	{
		[Ordinal(0)] [RED("IsDeviceHighlighted")] public CBool IsDeviceHighlighted { get; set; }
		[Ordinal(1)] [RED("IsNotifiedByMasterDevice")] public CBool IsNotifiedByMasterDevice { get; set; }

		public NotifyHighlightedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
