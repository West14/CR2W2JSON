using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayData : CVariable
	{
		[Ordinal(0)] [RED("widgetLibraryResource")] public redResourceReferenceScriptToken WidgetLibraryResource { get; set; }
		[Ordinal(1)] [RED("itemName")] public CName ItemName { get; set; }

		public gameTutorialOverlayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
