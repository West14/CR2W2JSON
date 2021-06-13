using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		[Ordinal(0)] [RED("peekScale")] public CFloat PeekScale { get; set; }

		public AnimFeature_PlayerPeekScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
