using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("readIndex")] public CInt32 ReadIndex { get; set; }
		[Ordinal(10)] [RED("writeIndex")] public CInt32 WriteIndex { get; set; }
		[Ordinal(11)] [RED("maxSize")] public CInt32 MaxSize { get; set; }
		[Ordinal(12)] [RED("entries")] public CArray<CString> Entries { get; set; }
		[Ordinal(13)] [RED("panel")] public inkVerticalPanelWidgetReference Panel { get; set; }
		[Ordinal(14)] [RED("onNewEntries")] public CUInt32 OnNewEntries { get; set; }
		[Ordinal(15)] [RED("onHide")] public CUInt32 OnHide { get; set; }

		public activityLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
