using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrowserController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("homeButton")] public inkWidgetReference HomeButton { get; set; }
		[Ordinal(2)] [RED("homeButtonCoontroller")] public CHandle<LinkController> HomeButtonCoontroller { get; set; }
		[Ordinal(3)] [RED("addressText")] public inkTextWidgetReference AddressText { get; set; }
		[Ordinal(4)] [RED("pageContentRoot")] public inkWidgetReference PageContentRoot { get; set; }
		[Ordinal(5)] [RED("spinnerPath")] public redResourceReferenceScriptToken SpinnerPath { get; set; }
		[Ordinal(6)] [RED("webPageLibraryID")] public CName WebPageLibraryID { get; set; }
		[Ordinal(7)] [RED("defaultDevicePage")] public CString DefaultDevicePage { get; set; }
		[Ordinal(8)] [RED("gameController")] public CHandle<BrowserGameController> GameController { get; set; }
		[Ordinal(9)] [RED("websiteData")] public CArray<wCHandle<gameJournalInternetPage>> WebsiteData { get; set; }
		[Ordinal(10)] [RED("currentRequestedPage")] public CString CurrentRequestedPage { get; set; }
		[Ordinal(11)] [RED("currentPage")] public wCHandle<inkCompoundWidget> CurrentPage { get; set; }
		[Ordinal(12)] [RED("spinner")] public wCHandle<inkWidget> Spinner { get; set; }

		public BrowserController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
