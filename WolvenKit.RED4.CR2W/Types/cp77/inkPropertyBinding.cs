using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPropertyBinding : CVariable
	{
		[Ordinal(0)] [RED("propertyName")] public CName PropertyName { get; set; }
		[Ordinal(1)] [RED("stylePath")] public CName StylePath { get; set; }

		public inkPropertyBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
