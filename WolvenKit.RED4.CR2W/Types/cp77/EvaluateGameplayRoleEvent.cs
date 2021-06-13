using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EvaluateGameplayRoleEvent : redEvent
	{
		[Ordinal(0)] [RED("force")] public CBool Force { get; set; }

		public EvaluateGameplayRoleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
