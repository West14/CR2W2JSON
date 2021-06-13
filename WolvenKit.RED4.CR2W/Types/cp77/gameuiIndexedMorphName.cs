using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiIndexedMorphName : CVariable
	{
		[Ordinal(0)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)] [RED("morphName")] public CName MorphName { get; set; }
		[Ordinal(2)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(3)] [RED("tags")] public redTagList Tags { get; set; }

		public gameuiIndexedMorphName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
