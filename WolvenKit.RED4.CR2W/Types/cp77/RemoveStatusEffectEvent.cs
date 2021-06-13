using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("effectID")] public TweakDBID EffectID { get; set; }
		[Ordinal(1)] [RED("removeCount")] public CUInt32 RemoveCount { get; set; }

		public RemoveStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
