using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineTestThreeOutput : IScriptable
	{
		[Ordinal(0)] [RED("counter")] public CInt32 Counter { get; set; }

		public PlayerStateMachineTestThreeOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
