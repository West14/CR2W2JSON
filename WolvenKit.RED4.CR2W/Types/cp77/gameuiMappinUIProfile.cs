using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinUIProfile : CVariable
	{
		[Ordinal(0)] [RED("widgetResource")] public redResourceReferenceScriptToken WidgetResource { get; set; }
		[Ordinal(1)] [RED("widgetLibraryID")] public CName WidgetLibraryID { get; set; }
		[Ordinal(2)] [RED("spawn")] public CHandle<gamedataMappinUISpawnProfile_Record> Spawn { get; set; }
		[Ordinal(3)] [RED("runtime")] public CHandle<gamedataMappinUIRuntimeProfile_Record> Runtime { get; set; }

		public gameuiMappinUIProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
