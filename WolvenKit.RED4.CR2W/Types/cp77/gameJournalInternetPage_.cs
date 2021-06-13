using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetPage_ : gameJournalEntry
	{
		[Ordinal(1)] [RED("address")] public CString Address { get; set; }
		[Ordinal(2)] [RED("factsToSet")] public CArray<gameJournalFactNameValue> FactsToSet { get; set; }
		[Ordinal(3)] [RED("additionallyFilledFromScripts")] public CBool AdditionallyFilledFromScripts { get; set; }
		[Ordinal(4)] [RED("widgetFile")] public raRef<inkWidgetLibraryResource> WidgetFile { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(6)] [RED("texts")] public CArray<CHandle<gameJournalInternetText>> Texts { get; set; }
		[Ordinal(7)] [RED("rectangles")] public CArray<CHandle<gameJournalInternetRectangle>> Rectangles { get; set; }
		[Ordinal(8)] [RED("images")] public CArray<CHandle<gameJournalInternetImage>> Images { get; set; }
		[Ordinal(9)] [RED("videos")] public CArray<CHandle<gameJournalInternetVideo>> Videos { get; set; }

		public gameJournalInternetPage_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
