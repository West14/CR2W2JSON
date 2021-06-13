using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleResource : CResource
	{
		[Ordinal(1)] [RED("styles")] public CArray<inkStyle> Styles { get; set; }
		[Ordinal(2)] [RED("styleImports")] public CArray<rRef<inkStyleResource>> StyleImports { get; set; }
		[Ordinal(3)] [RED("themes")] public CArray<inkStyleTheme> Themes { get; set; }
		[Ordinal(4)] [RED("hideInInheritingStyles")] public CBool HideInInheritingStyles { get; set; }

		public inkStyleResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
