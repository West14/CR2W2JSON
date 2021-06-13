using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensesOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(2)] [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(3)] [RED("attitudeGroup")] public CName AttitudeGroup { get; set; }
		[Ordinal(4)] [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }

		public SensesOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
