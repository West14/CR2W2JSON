using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReadyEvents : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("timeStamp")] public CFloat TimeStamp { get; set; }

		public ReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
