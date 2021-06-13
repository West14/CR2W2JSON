using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("viewTemplate")] public raRef<entEntityTemplate> ViewTemplate { get; set; }
		[Ordinal(4)] [RED("viewEnvironmentDefinition")] public rRef<worldEnvironmentAreaParameters> ViewEnvironmentDefinition { get; set; }
		[Ordinal(5)] [RED("cursorTemplate")] public raRef<entEntityTemplate> CursorTemplate { get; set; }

		public gameuiWorldMapPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
