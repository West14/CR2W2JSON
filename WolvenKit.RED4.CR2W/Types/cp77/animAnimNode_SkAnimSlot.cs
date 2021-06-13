using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimSlot : animAnimNode_SkAnim
	{
		[Ordinal(30)] [RED("forFacialIdle")] public CBool ForFacialIdle { get; set; }

		public animAnimNode_SkAnimSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
