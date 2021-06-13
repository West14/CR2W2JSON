using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] [RED("nodeRef")] public LibTreeDefNodeRef NodeRef { get; set; }
		[Ordinal(2)] [RED("offset")] public LibTreeDefVector Offset { get; set; }
		[Ordinal(3)] [RED("doNavTest")] public CBool DoNavTest { get; set; }

		public AICTreeNodeActionTeleportToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
