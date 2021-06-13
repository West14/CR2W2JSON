using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplinePointDefinition : ISerializable
	{
		[Ordinal(0)] [RED("pointType")] public CEnum<worldPatrolSplinePointTypes> PointType { get; set; }
		[Ordinal(1)] [RED("node")] public NodeRef Node { get; set; }
		[Ordinal(2)] [RED("target")] public gameEntityReference Target { get; set; }

		public worldPatrolSplinePointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
