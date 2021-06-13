using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] [RED("state")] public wCHandle<TemporalPrereqState> State { get; set; }

		public TemporalPrereqDelayCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
