using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLevelUpData : CVariable
	{
		[Ordinal(0)] [RED("lvl")] public CInt32 Lvl { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }
		[Ordinal(2)] [RED("perkPoints")] public CInt32 PerkPoints { get; set; }
		[Ordinal(3)] [RED("attributePoints")] public CInt32 AttributePoints { get; set; }
		[Ordinal(4)] [RED("disableAction")] public CBool DisableAction { get; set; }

		public questLevelUpData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
