using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsSetVisibility : redEvent
	{
		[Ordinal(0)] [RED("visible")] public CBool Visible { get; set; }
		[Ordinal(1)] [RED("source")] public CEnum<entVisibilityParamSource> Source { get; set; }

		public enteventsSetVisibility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
