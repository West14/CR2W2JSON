using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayEquipmentArea : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("equipmentAreas")] public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas { get; set; }
		[Ordinal(2)] [RED("numberOfSlots")] public CInt32 NumberOfSlots { get; set; }

		public InventoryItemDisplayEquipmentArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
