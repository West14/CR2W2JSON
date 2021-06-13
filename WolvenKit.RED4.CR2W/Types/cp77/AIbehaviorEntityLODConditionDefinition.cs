using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("any")] public CArray<CEnum<AIbehaviorEntityLODConditions>> Any { get; set; }
		[Ordinal(2)] [RED("all")] public CArray<CEnum<AIbehaviorEntityLODConditions>> All { get; set; }
		[Ordinal(3)] [RED("none")] public CArray<CEnum<AIbehaviorEntityLODConditions>> None { get; set; }

		public AIbehaviorEntityLODConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
