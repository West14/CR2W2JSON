using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("fanSetup")] public FanSetup FanSetup { get; set; }

		public FanControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
