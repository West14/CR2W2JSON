using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedTriggeredPrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("listenerInt")] public CUInt32 ListenerInt { get; set; }

		public WoundedTriggeredPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
