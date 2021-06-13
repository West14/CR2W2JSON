using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_CNameEvaluator_ValueOrBlackboard : gameIEffectParameter_CNameEvaluator
	{
		[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
		[Ordinal(1)] [RED("value")] public CName Value { get; set; }

		public gameEffectParameter_CNameEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
