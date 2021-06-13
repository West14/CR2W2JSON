using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolData : CVariable
	{
		[Ordinal(0)] [RED("ownerID")] public gameStatsObjectID OwnerID { get; set; }
		[Ordinal(1)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<gamedataStatPoolType> Type { get; set; }
		[Ordinal(3)] [RED("modifiers", 2)] public CArrayFixedSize<gameStatPoolModifier> Modifiers { get; set; }
		[Ordinal(4)] [RED("alternativeModifierRecords", 2)] public CArrayFixedSize<TweakDBID> AlternativeModifierRecords { get; set; }
		[Ordinal(5)] [RED("stat")] public CEnum<gamedataStatType> Stat { get; set; }
		[Ordinal(6)] [RED("maxValue")] public CFloat MaxValue { get; set; }
		[Ordinal(7)] [RED("customLimitValue")] public CFloat CustomLimitValue { get; set; }
		[Ordinal(8)] [RED("changeMode")] public CEnum<gameStatPoolDataValueChangeMode> ChangeMode { get; set; }
		[Ordinal(9)] [RED("bonus")] public CFloat Bonus { get; set; }
		[Ordinal(10)] [RED("bonusType")] public CEnum<gameStatPoolDataBonusType> BonusType { get; set; }
		[Ordinal(11)] [RED("currentValue")] public CFloat CurrentValue { get; set; }
		[Ordinal(12)] [RED("modificationDelay")] public CFloat ModificationDelay { get; set; }
		[Ordinal(13)] [RED("modificationStatus")] public CEnum<gameStatPoolDataStatPoolModificationStatus> ModificationStatus { get; set; }

		public gameStatPoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
