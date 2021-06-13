using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerControlDeviceData : CVariable
	{
		[Ordinal(0)] [RED("currentYawModifier")] public CFloat CurrentYawModifier { get; set; }
		[Ordinal(1)] [RED("currentPitchModifier")] public CFloat CurrentPitchModifier { get; set; }

		public PlayerControlDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
