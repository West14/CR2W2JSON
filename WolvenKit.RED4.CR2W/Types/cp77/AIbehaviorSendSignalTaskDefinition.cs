using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(2)] [RED("startAction")] public CEnum<gameBoolSignalAction> StartAction { get; set; }
		[Ordinal(3)] [RED("startActionUserData")] public CHandle<gameSignalUserDataDefinition> StartActionUserData { get; set; }
		[Ordinal(4)] [RED("endAction")] public CEnum<gameBoolSignalAction> EndAction { get; set; }
		[Ordinal(5)] [RED("endActionUserData")] public CHandle<gameSignalUserDataDefinition> EndActionUserData { get; set; }

		public AIbehaviorSendSignalTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
