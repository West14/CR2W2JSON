using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddOrRemoveListenerForGOEvent : redEvent
	{
		[Ordinal(0)] [RED("listener")] public CHandle<GameObjectListener> Listener { get; set; }
		[Ordinal(1)] [RED("shouldAdd")] public CBool ShouldAdd { get; set; }

		public AddOrRemoveListenerForGOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
