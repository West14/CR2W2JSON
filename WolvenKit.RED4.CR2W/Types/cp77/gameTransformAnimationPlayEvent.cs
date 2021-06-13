using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationPlayEvent : gameTransformAnimationEvent
	{
		[Ordinal(1)] [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(2)] [RED("looping")] public CBool Looping { get; set; }
		[Ordinal(3)] [RED("timesPlayed")] public CUInt32 TimesPlayed { get; set; }
		[Ordinal(4)] [RED("useEntitySetup")] public CBool UseEntitySetup { get; set; }

		public gameTransformAnimationPlayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
