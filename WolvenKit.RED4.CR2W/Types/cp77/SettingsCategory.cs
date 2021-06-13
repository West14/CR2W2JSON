using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsCategory : CVariable
	{
		[Ordinal(0)] [RED("label")] public CName Label { get; set; }
		[Ordinal(1)] [RED("subcategories")] public CArray<SettingsCategory> Subcategories { get; set; }
		[Ordinal(2)] [RED("options")] public CArray<CHandle<userSettingsVar>> Options { get; set; }
		[Ordinal(3)] [RED("isEmpty")] public CBool IsEmpty { get; set; }
		[Ordinal(4)] [RED("groupPath")] public CName GroupPath { get; set; }

		public SettingsCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
