using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] [RED("itemSortMode")] public CEnum<ItemSortMode> ItemSortMode { get; set; }
		[Ordinal(1)] [RED("attachmentsList")] public CArray<CEnum<gamedataItemType>> AttachmentsList { get; set; }
		[Ordinal(2)] [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(3)] [RED("itemFilterType")] public CEnum<ItemFilterCategory> ItemFilterType { get; set; }

		public BackpackDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
