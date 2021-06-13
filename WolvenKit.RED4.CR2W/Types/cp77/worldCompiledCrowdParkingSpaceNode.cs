using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		[Ordinal(4)] [RED("crowdCreationIndex")] public CUInt32 CrowdCreationIndex { get; set; }
		[Ordinal(5)] [RED("parkingSpaceId")] public CUInt32 ParkingSpaceId { get; set; }

		public worldCompiledCrowdParkingSpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
