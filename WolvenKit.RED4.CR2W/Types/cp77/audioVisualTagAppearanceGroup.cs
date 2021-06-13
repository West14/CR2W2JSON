using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagAppearanceGroup : CVariable
	{
		[Ordinal(0)] [RED("appearances")] public CArray<CName> Appearances { get; set; }
		[Ordinal(1)] [RED("visualTags")] public CArray<CName> VisualTags { get; set; }

		public audioVisualTagAppearanceGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
