using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrackedLocation : CVariable
	{
		[Ordinal(0)] [RED("lastKnown")] public AILocationInformation LastKnown { get; set; }
		[Ordinal(1)] [RED("location")] public AILocationInformation Location { get; set; }
		[Ordinal(2)] [RED("sharedLocation")] public AILocationInformation SharedLocation { get; set; }
		[Ordinal(3)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(4)] [RED("accuracy")] public CFloat Accuracy { get; set; }
		[Ordinal(5)] [RED("sharedAccuracy")] public CFloat SharedAccuracy { get; set; }
		[Ordinal(6)] [RED("sharedTimeDelay")] public CFloat SharedTimeDelay { get; set; }
		[Ordinal(7)] [RED("threat")] public CFloat Threat { get; set; }
		[Ordinal(8)] [RED("speed")] public Vector4 Speed { get; set; }
		[Ordinal(9)] [RED("visible")] public CBool Visible { get; set; }
		[Ordinal(10)] [RED("invalidExpectation")] public CBool InvalidExpectation { get; set; }
		[Ordinal(11)] [RED("status")] public CEnum<AITrackedStatusType> Status { get; set; }
		[Ordinal(12)] [RED("sharedLastKnown")] public AILocationInformation SharedLastKnown { get; set; }

		public AITrackedLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
