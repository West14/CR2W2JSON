using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISetCombatPresetCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] [RED("combatPreset")] public CEnum<EAICombatPreset> CombatPreset { get; set; }

		public AISetCombatPresetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
