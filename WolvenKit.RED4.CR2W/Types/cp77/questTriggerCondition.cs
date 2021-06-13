using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTriggerCondition : questCondition
	{
		[Ordinal(0)] [RED("type")] public CEnum<questTriggerConditionType> Type { get; set; }
		[Ordinal(1)] [RED("triggerAreaRef")] public NodeRef TriggerAreaRef { get; set; }
		[Ordinal(2)] [RED("activatorRef")] public gameEntityReference ActivatorRef { get; set; }
		[Ordinal(3)] [RED("isPlayerActivator")] public CBool IsPlayerActivator { get; set; }

		public questTriggerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
