using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnLibraryItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("libraryID")] public CName LibraryID { get; set; }

		public SpawnLibraryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
