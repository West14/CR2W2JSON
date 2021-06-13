using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAdvertSoundMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("audioEvent1")] public CName AudioEvent1 { get; set; }
		[Ordinal(2)] [RED("audioEvent2")] public CName AudioEvent2 { get; set; }
		[Ordinal(3)] [RED("audioEvent3")] public CName AudioEvent3 { get; set; }
		[Ordinal(4)] [RED("audioEvent4")] public CName AudioEvent4 { get; set; }
		[Ordinal(5)] [RED("useCustomDelays")] public CBool UseCustomDelays { get; set; }
		[Ordinal(6)] [RED("speedOfSound")] public CFloat SpeedOfSound { get; set; }
		[Ordinal(7)] [RED("soundDelay1")] public CFloat SoundDelay1 { get; set; }
		[Ordinal(8)] [RED("soundDelay2")] public CFloat SoundDelay2 { get; set; }
		[Ordinal(9)] [RED("soundDelay3")] public CFloat SoundDelay3 { get; set; }
		[Ordinal(10)] [RED("soundDelay4")] public CFloat SoundDelay4 { get; set; }

		public audioAdvertSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
