using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorldMarker : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<scnWorldMarkerType> Type { get; set; }
		[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public scnWorldMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
