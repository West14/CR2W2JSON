using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionSlideParams : CVariable
	{
		[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(1)] [RED("directionAngle")] public CFloat DirectionAngle { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(4)] [RED("slideToTarget")] public CBool SlideToTarget { get; set; }
		[Ordinal(5)] [RED("debugDrawSlideLines")] public CBool DebugDrawSlideLines { get; set; }

		public AIActionSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
