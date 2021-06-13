using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<DoorStateOperationTriggerData> TriggerData { get; set; }
		[Ordinal(1)] [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(2)] [RED("cachedState")] public CEnum<EDoorStatus> CachedState { get; set; }

		public DoorStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
