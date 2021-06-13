using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_RebalanceItemEvent : redEvent
	{
		[Ordinal(0)] [RED("reqLevel")] public CFloat ReqLevel { get; set; }

		public DEBUG_RebalanceItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
