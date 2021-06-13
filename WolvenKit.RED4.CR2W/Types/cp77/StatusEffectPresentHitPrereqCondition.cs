using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("checkType")] public CName CheckType { get; set; }
		[Ordinal(2)] [RED("statusEffectParam")] public CName StatusEffectParam { get; set; }
		[Ordinal(3)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(4)] [RED("objectToCheck")] public CName ObjectToCheck { get; set; }

		public StatusEffectPresentHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
