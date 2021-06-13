using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestStopFollowingTarget : ActionBool
	{
		[Ordinal(25)] [RED("targetEntityID")] public entEntityID TargetEntityID { get; set; }

		public QuestStopFollowingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
