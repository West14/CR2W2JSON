using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAudioEvent : redEvent
	{
		[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)] [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(2)] [RED("nameData")] public CName NameData { get; set; }
		[Ordinal(3)] [RED("floatData")] public CFloat FloatData { get; set; }
		[Ordinal(4)] [RED("eventType")] public CEnum<audioEventActionType> EventType { get; set; }
		[Ordinal(5)] [RED("eventFlags")] public CEnum<audioAudioEventFlags> EventFlags { get; set; }

		public entAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
