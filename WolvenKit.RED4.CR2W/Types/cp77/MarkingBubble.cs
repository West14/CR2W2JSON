using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarkingBubble : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("delaySecondsPerMeterOfDistance")] public CFloat DelaySecondsPerMeterOfDistance { get; set; }
		[Ordinal(2)] [RED("delayAdditionalRandomDelayMax")] public CFloat DelayAdditionalRandomDelayMax { get; set; }

		public MarkingBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
