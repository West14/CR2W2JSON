using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToPositionState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("target")] public Vector3 Target { get; set; }
		[Ordinal(6)] [RED("useSpotReservation")] public CBool UseSpotReservation { get; set; }
		[Ordinal(7)] [RED("usePathfinding")] public CBool UsePathfinding { get; set; }
		[Ordinal(8)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(9)] [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(10)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(11)] [RED("strafingTarget")] public wCHandle<gameObject> StrafingTarget { get; set; }

		public gameActionMoveToPositionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
