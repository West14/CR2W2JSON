using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("masterVolume")] public CFloat MasterVolume { get; set; }
		[Ordinal(2)] [RED("sfxVolume")] public CFloat SfxVolume { get; set; }
		[Ordinal(3)] [RED("musicVolume")] public CFloat MusicVolume { get; set; }
		[Ordinal(4)] [RED("voVolume")] public CFloat VoVolume { get; set; }
		[Ordinal(5)] [RED("uiMenuVolume")] public CFloat UiMenuVolume { get; set; }
		[Ordinal(6)] [RED("onStartupEvent")] public CName OnStartupEvent { get; set; }

		public audioMixSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
