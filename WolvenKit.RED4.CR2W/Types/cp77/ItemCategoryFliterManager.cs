using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCategoryFliterManager : IScriptable
	{
		[Ordinal(0)] [RED("filtersToCheck")] public CArray<CEnum<ItemFilterCategory>> FiltersToCheck { get; set; }
		[Ordinal(1)] [RED("filters")] public CArray<CEnum<ItemFilterCategory>> Filters { get; set; }
		[Ordinal(2)] [RED("isOrderDirty")] public CBool IsOrderDirty { get; set; }

		public ItemCategoryFliterManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
