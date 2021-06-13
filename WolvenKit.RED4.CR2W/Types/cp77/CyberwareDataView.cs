using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] [RED("itemFilterType")] public CEnum<RipperdocFilter> ItemFilterType { get; set; }
		[Ordinal(1)] [RED("itemSortMode")] public CEnum<ItemSortMode> ItemSortMode { get; set; }
		[Ordinal(2)] [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }

		public CyberwareDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
