using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationElement : CVariable
	{
		[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(1)] [RED("animOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }

		public AnimationElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
