using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("inputSocketCount")] public CUInt32 InputSocketCount { get; set; }
		[Ordinal(3)] [RED("outputSocketCount")] public CUInt32 OutputSocketCount { get; set; }

		public questLogicalBaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
