using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTrafficDataPackage : CVariable
	{
		[Ordinal(0)] [RED("crowdEntryOwners")] public gameCrowdCommunityEntryOwnersData CrowdEntryOwners { get; set; }
		[Ordinal(1)] [RED("crowdTrafficData")] public gameCompiledCrowdTrafficData CrowdTrafficData { get; set; }

		public gameCrowdTrafficDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
