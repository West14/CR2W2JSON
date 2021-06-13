using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlot : animAnimNode_Base
	{
		[Ordinal(11)] [RED("name")] public CName Name { get; set; }
		[Ordinal(12)] [RED("dontDeactivateInput")] public CBool DontDeactivateInput { get; set; }
		[Ordinal(13)] [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_GraphSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
