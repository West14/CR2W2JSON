using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkFlags : CVariable
	{
		[Ordinal(0)] [RED("renderInScene")] public CBool RenderInScene { get; set; }
		[Ordinal(1)] [RED("renderInShadows")] public CBool RenderInShadows { get; set; }
		[Ordinal(2)] [RED("isTwoSided")] public CBool IsTwoSided { get; set; }
		[Ordinal(3)] [RED("isRayTracedEmissive")] public CBool IsRayTracedEmissive { get; set; }

		public meshChunkFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
