using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		[Ordinal(0)] [RED("timeToLive")] public CFloat TimeToLive { get; set; }

		public gameEffectDuration_PredefinedTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
