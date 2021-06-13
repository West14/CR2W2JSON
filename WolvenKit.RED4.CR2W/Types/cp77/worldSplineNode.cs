using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSplineNode : worldSocketNode
	{
		[Ordinal(4)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
		[Ordinal(5)] [RED("destSnapedNode")] public NodeRef DestSnapedNode { get; set; }
		[Ordinal(6)] [RED("destSnapedSocketName")] public CName DestSnapedSocketName { get; set; }
		[Ordinal(7)] [RED("entrySnapedNode")] public NodeRef EntrySnapedNode { get; set; }
		[Ordinal(8)] [RED("entrySnapedSocketName")] public CName EntrySnapedSocketName { get; set; }

		public worldSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
