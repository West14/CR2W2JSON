using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapData : IScriptable
	{
		[Ordinal(0)] [RED("action")] public CEnum<gamedataWorkspotActionType> Action { get; set; }
		[Ordinal(1)] [RED("workspots")] public CArray<CHandle<WorkspotEntryData>> Workspots { get; set; }

		public WorkspotMapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
