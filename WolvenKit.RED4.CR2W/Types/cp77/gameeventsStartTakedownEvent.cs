using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsStartTakedownEvent : redEvent
	{
		[Ordinal(0)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)] [RED("slideTime")] public CFloat SlideTime { get; set; }
		[Ordinal(2)] [RED("actionName")] public CName ActionName { get; set; }

		public gameeventsStartTakedownEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
