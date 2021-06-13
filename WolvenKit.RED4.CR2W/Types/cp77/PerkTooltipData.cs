using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] [RED("perkType")] public CEnum<gamedataPerkType> PerkType { get; set; }
		[Ordinal(2)] [RED("perkArea")] public CEnum<gamedataPerkArea> PerkArea { get; set; }
		[Ordinal(3)] [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(4)] [RED("proficiency")] public CEnum<gamedataProficiencyType> Proficiency { get; set; }
		[Ordinal(5)] [RED("perkData")] public CHandle<PerkDisplayData> PerkData { get; set; }
		[Ordinal(6)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public PerkTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
