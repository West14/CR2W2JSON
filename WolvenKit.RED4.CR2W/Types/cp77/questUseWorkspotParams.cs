using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotParams : CVariable
	{
		[Ordinal(0)] [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }
		[Ordinal(1)] [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }

		public questUseWorkspotParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
