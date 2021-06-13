using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransition : DefaultTransition
	{
		[Ordinal(0)] [RED("stateMachineInitData")] public wCHandle<VehicleTransitionInitData> StateMachineInitData { get; set; }

		public VehicleTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
