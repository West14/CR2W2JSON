using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		[Ordinal(1)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(2)] [RED("skipToEnd")] public CBool SkipToEnd { get; set; }
		[Ordinal(3)] [RED("forcePlay")] public CBool ForcePlay { get; set; }

		public gameTransformAnimationSkipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
