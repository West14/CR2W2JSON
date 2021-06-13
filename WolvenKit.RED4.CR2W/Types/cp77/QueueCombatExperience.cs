using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QueueCombatExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("amount")] public CFloat Amount { get; set; }
		[Ordinal(2)] [RED("experienceType")] public CEnum<gamedataProficiencyType> ExperienceType { get; set; }
		[Ordinal(3)] [RED("entity")] public entEntityID Entity { get; set; }

		public QueueCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
