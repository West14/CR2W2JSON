using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Vault : animAnimFeature_Climb
	{
		[Ordinal(10)] [RED("landPosition")] public Vector4 LandPosition { get; set; }
		[Ordinal(11)] [RED("travellingTime")] public CFloat TravellingTime { get; set; }
		[Ordinal(12)] [RED("obstacleDepth")] public CFloat ObstacleDepth { get; set; }

		public animAnimFeature_Vault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
