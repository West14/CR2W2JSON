using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateCoverEvents : CoverActionEventsTransition
	{
		[Ordinal(0)] [RED("usingCover")] public CBool UsingCover { get; set; }

		public ActivateCoverEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
