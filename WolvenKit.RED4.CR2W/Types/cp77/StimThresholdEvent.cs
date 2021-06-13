using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimThresholdEvent : redEvent
	{
		[Ordinal(0)] [RED("reset")] public CBool Reset { get; set; }
		[Ordinal(1)] [RED("timeThreshold")] public CFloat TimeThreshold { get; set; }

		public StimThresholdEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
