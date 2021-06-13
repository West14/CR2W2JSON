using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedDeviceOperationTriggerEvent : redEvent
	{
		[Ordinal(0)] [RED("triggerHandler")] public CHandle<DeviceOperationsTrigger> TriggerHandler { get; set; }
		[Ordinal(1)] [RED("namedOperation")] public CHandle<OperationExecutionData> NamedOperation { get; set; }

		public DelayedDeviceOperationTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
