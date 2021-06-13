using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySkillCondition : GameplayConditionBase
	{
		[Ordinal(1)] [RED("skillToCheck")] public TweakDBID SkillToCheck { get; set; }
		[Ordinal(2)] [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }

		public GameplaySkillCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
