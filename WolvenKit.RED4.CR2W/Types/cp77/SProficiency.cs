using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SProficiency : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }
		[Ordinal(1)] [RED("currentLevel")] public CInt32 CurrentLevel { get; set; }
		[Ordinal(2)] [RED("maxLevel")] public CInt32 MaxLevel { get; set; }
		[Ordinal(3)] [RED("isAtMaxLevel")] public CBool IsAtMaxLevel { get; set; }
		[Ordinal(4)] [RED("currentExp")] public CInt32 CurrentExp { get; set; }
		[Ordinal(5)] [RED("expToLevel")] public CInt32 ExpToLevel { get; set; }
		[Ordinal(6)] [RED("spentPerkPoints")] public CInt32 SpentPerkPoints { get; set; }

		public SProficiency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
