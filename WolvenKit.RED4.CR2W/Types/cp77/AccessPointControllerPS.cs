using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessPointControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("rewardNotificationIcons")] public CArray<CString> RewardNotificationIcons { get; set; }
		[Ordinal(105)] [RED("rewardNotificationString")] public CString RewardNotificationString { get; set; }
		[Ordinal(106)] [RED("accessPointSkillChecks")] public CHandle<HackingContainer> AccessPointSkillChecks { get; set; }
		[Ordinal(107)] [RED("isBreached")] public CBool IsBreached { get; set; }
		[Ordinal(108)] [RED("isVirtual")] public CBool IsVirtual { get; set; }

		public AccessPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
