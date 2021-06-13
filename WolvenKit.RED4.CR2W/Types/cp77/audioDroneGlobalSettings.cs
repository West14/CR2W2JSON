using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDroneGlobalSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("speedRtpc")] public CName SpeedRtpc { get; set; }
		[Ordinal(2)] [RED("thrustRtpc")] public CName ThrustRtpc { get; set; }

		public audioDroneGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
