using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textTextBlockFontStyle : CVariable
	{
		[Ordinal(0)] [RED("fontStyle")] public CName FontStyle { get; set; }
		[Ordinal(1)] [RED("outlineSize")] public CInt32 OutlineSize { get; set; }
		[Ordinal(2)] [RED("outlineColor")] public HDRColor OutlineColor { get; set; }

		public textTextBlockFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
