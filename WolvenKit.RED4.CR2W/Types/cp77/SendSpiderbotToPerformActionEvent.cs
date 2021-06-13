using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendSpiderbotToPerformActionEvent : redEvent
	{
		[Ordinal(0)] [RED("executor")] public wCHandle<gameObject> Executor { get; set; }

		public SendSpiderbotToPerformActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
