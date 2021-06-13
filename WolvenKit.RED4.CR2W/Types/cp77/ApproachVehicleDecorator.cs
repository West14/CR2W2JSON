using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApproachVehicleDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(1)] [RED("mountRequest")] public CHandle<AIArgumentMapping> MountRequest { get; set; }
		[Ordinal(2)] [RED("entryPoint")] public CHandle<AIArgumentMapping> EntryPoint { get; set; }
		[Ordinal(3)] [RED("doorOpenRequestSent")] public CBool DoorOpenRequestSent { get; set; }
		[Ordinal(4)] [RED("closeDoor")] public CBool CloseDoor { get; set; }
		[Ordinal(5)] [RED("mountEventData")] public CHandle<gameMountEventData> MountEventData { get; set; }
		[Ordinal(6)] [RED("mountRequestData")] public CHandle<gameMountEventData> MountRequestData { get; set; }
		[Ordinal(7)] [RED("mountEntryPoint")] public Vector4 MountEntryPoint { get; set; }
		[Ordinal(8)] [RED("activationTime")] public EngineTime ActivationTime { get; set; }
		[Ordinal(9)] [RED("runCompanionCheck")] public CBool RunCompanionCheck { get; set; }

		public ApproachVehicleDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
