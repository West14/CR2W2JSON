using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineTransition : graphGraphConnectionDefinition
	{
		[Ordinal(2)] [RED("transitionCondition")] public CHandle<gamestateMachineFunctor> TransitionCondition { get; set; }

		public gamestateMachineTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
