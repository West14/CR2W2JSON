using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlinkingEvent : redEvent
	{
		[Ordinal(0)] [RED("requestNumber")] public CInt32 RequestNumber { get; set; }

		public BlinkingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
