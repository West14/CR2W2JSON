using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionInteractivityInfo : CVariable
	{
		[Ordinal(0)] [RED("isExternal")] public CBool IsExternal { get; set; }
		[Ordinal(1)] [RED("isRemote")] public CBool IsRemote { get; set; }
		[Ordinal(2)] [RED("isDirect")] public CBool IsDirect { get; set; }

		public ActionInteractivityInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
