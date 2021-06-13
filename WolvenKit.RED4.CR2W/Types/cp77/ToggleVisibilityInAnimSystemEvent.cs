using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibilityInAnimSystemEvent : redEvent
	{
		[Ordinal(0)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(1)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(2)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }

		public ToggleVisibilityInAnimSystemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
