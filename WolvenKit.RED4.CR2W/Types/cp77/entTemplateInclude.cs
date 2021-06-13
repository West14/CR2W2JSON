using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateInclude : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("template")] public raRef<entEntityTemplate> Template { get; set; }

		public entTemplateInclude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
