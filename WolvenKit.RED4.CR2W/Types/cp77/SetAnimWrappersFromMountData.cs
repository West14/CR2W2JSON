using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAnimWrappersFromMountData : AIVehicleTaskAbstract
	{
		[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }

		public SetAnimWrappersFromMountData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
