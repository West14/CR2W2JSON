using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlacementEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(7)] [RED("targetWaypoint")] public scnMarker TargetWaypoint { get; set; }

		public scnPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
