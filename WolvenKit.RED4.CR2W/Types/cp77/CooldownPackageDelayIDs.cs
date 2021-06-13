using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownPackageDelayIDs : CVariable
	{
		[Ordinal(0)] [RED("packageID")] public CooldownStorageID PackageID { get; set; }
		[Ordinal(1)] [RED("delayIDs")] public CArray<gameDelayID> DelayIDs { get; set; }

		public CooldownPackageDelayIDs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
