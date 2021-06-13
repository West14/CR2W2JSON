using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayItemCondition : GameplayConditionBase
	{
		[Ordinal(1)] [RED("itemToCheck")] public TweakDBID ItemToCheck { get; set; }

		public GameplayItemCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
