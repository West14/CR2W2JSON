using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterReaction_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isAnyReaction")] public CBool IsAnyReaction { get; set; }
		[Ordinal(2)] [RED("reactionBehaviorID")] public TweakDBID ReactionBehaviorID { get; set; }

		public questCharacterReaction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
