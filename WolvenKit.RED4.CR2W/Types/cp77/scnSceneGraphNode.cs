using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneGraphNode : ISerializable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("ffStrategy")] public CEnum<scnFastForwardStrategy> FfStrategy { get; set; }
		[Ordinal(2)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }

		public scnSceneGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
