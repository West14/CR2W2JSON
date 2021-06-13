using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFadeInOut_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] [RED("fadeColor")] public CColor FadeColor { get; set; }
		[Ordinal(1)] [RED("fadeIn")] public CBool FadeIn { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }

		public questSetFadeInOut_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
