using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierSave : CVariable
	{
		[Ordinal(0)] [RED("statModifierUnions")] public CArray<CHandle<gameStatModifierData>> StatModifierUnions { get; set; }
		[Ordinal(1)] [RED("statsObjectID")] public gameStatsObjectID StatsObjectID { get; set; }
		[Ordinal(2)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(3)] [RED("seed")] public CUInt32 Seed { get; set; }

		public gameStatModifierSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
