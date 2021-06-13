using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSimulationFilter : CVariable
	{
		[Ordinal(0)] [RED("mask1")] public CUInt64 Mask1 { get; set; }
		[Ordinal(1)] [RED("mask2")] public CUInt64 Mask2 { get; set; }

		public physicsSimulationFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
