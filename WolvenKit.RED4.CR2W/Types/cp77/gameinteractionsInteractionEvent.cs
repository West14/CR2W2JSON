using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionEvent : redEvent
	{
		[Ordinal(0)] [RED("hotspot")] public wCHandle<gameObject> Hotspot { get; set; }
		[Ordinal(1)] [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(2)] [RED("eventType")] public CEnum<gameinteractionsEInteractionEventType> EventType { get; set; }
		[Ordinal(3)] [RED("layerData")] public gameinteractionsLayerData LayerData { get; set; }

		public gameinteractionsInteractionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
