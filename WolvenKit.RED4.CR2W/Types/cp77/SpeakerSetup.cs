using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeakerSetup : CVariable
	{
		[Ordinal(0)] [RED("defaultMusic")] public CEnum<ERadioStationList> DefaultMusic { get; set; }
		[Ordinal(1)] [RED("distractionMusic")] public CEnum<ERadioStationList> DistractionMusic { get; set; }
		[Ordinal(2)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(3)] [RED("glitchSFX")] public CName GlitchSFX { get; set; }
		[Ordinal(4)] [RED("useOnlyGlitchSFX")] public CBool UseOnlyGlitchSFX { get; set; }

		public SpeakerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
