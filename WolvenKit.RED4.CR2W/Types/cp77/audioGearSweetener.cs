using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGearSweetener : audioAudioMetadata
	{
		[Ordinal(1)] [RED("gear")] public CUInt32 Gear { get; set; }
		[Ordinal(2)] [RED("rpmThreshold")] public CFloat RpmThreshold { get; set; }
		[Ordinal(3)] [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(4)] [RED("soundEvent")] public CName SoundEvent { get; set; }
		[Ordinal(5)] [RED("burnoutFactor")] public CFloat BurnoutFactor { get; set; }

		public audioGearSweetener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
