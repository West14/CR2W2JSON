using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GravityChangeTrigger : gameObject
	{
		[Ordinal(40)] [RED("gravityType")] public CEnum<EGravityType> GravityType { get; set; }
		[Ordinal(41)] [RED("regularStateMachineName")] public CName RegularStateMachineName { get; set; }
		[Ordinal(42)] [RED("lowGravityStateMachineName")] public CName LowGravityStateMachineName { get; set; }

		public GravityChangeTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
