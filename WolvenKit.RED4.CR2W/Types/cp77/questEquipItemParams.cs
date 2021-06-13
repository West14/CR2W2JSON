using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEquipItemParams : questAICommandParams
	{
		[Ordinal(0)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<questNodeType> Type { get; set; }
		[Ordinal(2)] [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(3)] [RED("equipDurationOverride")] public CFloat EquipDurationOverride { get; set; }
		[Ordinal(4)] [RED("unequipDurationOverride")] public CFloat UnequipDurationOverride { get; set; }
		[Ordinal(5)] [RED("failIfItemNotFound")] public CBool FailIfItemNotFound { get; set; }
		[Ordinal(6)] [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(7)] [RED("equipLastWeapon")] public CBool EquipLastWeapon { get; set; }
		[Ordinal(8)] [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
		[Ordinal(9)] [RED("ignoreStateMachine")] public CBool IgnoreStateMachine { get; set; }
		[Ordinal(10)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(11)] [RED("equipTypes")] public CEnum<gameItemEquipContexts> EquipTypes { get; set; }
		[Ordinal(12)] [RED("unequipTypes")] public CEnum<gameItemUnequipContexts> UnequipTypes { get; set; }
		[Ordinal(13)] [RED("byItem")] public CBool ByItem { get; set; }

		public questEquipItemParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
