using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectSignalEvent : redEvent
	{
		[Ordinal(0)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
		[Ordinal(1)] [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(2)] [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(3)] [RED("flags")] public CArray<CEnum<EAIGateSignalFlags>> Flags { get; set; }
		[Ordinal(4)] [RED("repeatSignalDelay")] public CFloat RepeatSignalDelay { get; set; }

		public StatusEffectSignalEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
