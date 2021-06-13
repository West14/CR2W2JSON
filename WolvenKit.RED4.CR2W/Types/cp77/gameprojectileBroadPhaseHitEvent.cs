using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileBroadPhaseHitEvent : redEvent
	{
		[Ordinal(0)] [RED("traceResult")] public physicsTraceResult TraceResult { get; set; }
		[Ordinal(1)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)] [RED("hitObject")] public wCHandle<entEntity> HitObject { get; set; }
		[Ordinal(3)] [RED("hitComponent")] public wCHandle<entIComponent> HitComponent { get; set; }

		public gameprojectileBroadPhaseHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
