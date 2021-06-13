using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LODEnd : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_LODEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
