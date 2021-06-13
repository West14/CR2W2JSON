using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterReactionAction : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("reactionName")] public CName ReactionName { get; set; }
		[Ordinal(1)] [RED("onDeactivation")] public CBool OnDeactivation { get; set; }

		public UnregisterReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
