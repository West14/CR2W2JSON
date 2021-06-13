using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRegisterNewAbilityCooldownRequest : CVariable
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(1)] [RED("ownerItemId")] public gameItemID OwnerItemId { get; set; }
		[Ordinal(2)] [RED("ownerRecord")] public TweakDBID OwnerRecord { get; set; }
		[Ordinal(3)] [RED("cooldownName")] public CName CooldownName { get; set; }
		[Ordinal(4)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(5)] [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(6)] [RED("modifiable")] public CBool Modifiable { get; set; }
		[Ordinal(7)] [RED("abilityType")] public CEnum<gamedataStatType> AbilityType { get; set; }

		public gameRegisterNewAbilityCooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
