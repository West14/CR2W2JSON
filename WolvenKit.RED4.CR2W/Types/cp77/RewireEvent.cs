using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RewireEvent : redEvent
	{
		[Ordinal(0)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)] [RED("activatorID")] public entEntityID ActivatorID { get; set; }
		[Ordinal(2)] [RED("executor")] public wCHandle<gameObject> Executor { get; set; }
		[Ordinal(3)] [RED("state")] public CEnum<EDrillMachineRewireState> State { get; set; }
		[Ordinal(4)] [RED("sucess")] public CBool Sucess { get; set; }

		public RewireEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
