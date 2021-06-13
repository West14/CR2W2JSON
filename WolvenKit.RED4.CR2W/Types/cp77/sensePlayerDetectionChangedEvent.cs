using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sensePlayerDetectionChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("oldDetectionValue")] public CFloat OldDetectionValue { get; set; }
		[Ordinal(1)] [RED("newDetectionValue")] public CFloat NewDetectionValue { get; set; }

		public sensePlayerDetectionChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
