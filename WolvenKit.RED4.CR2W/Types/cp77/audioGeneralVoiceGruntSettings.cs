using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGeneralVoiceGruntSettings : CVariable
	{
		[Ordinal(0)] [RED("variationsCount")] public CUInt32 VariationsCount { get; set; }
		[Ordinal(1)] [RED("painLong")] public CName PainLong { get; set; }
		[Ordinal(2)] [RED("agressionShort")] public CName AgressionShort { get; set; }
		[Ordinal(3)] [RED("agressionLong")] public CName AgressionLong { get; set; }
		[Ordinal(4)] [RED("longFall")] public CName LongFall { get; set; }
		[Ordinal(5)] [RED("death")] public CName Death { get; set; }
		[Ordinal(6)] [RED("silentDeath")] public CName SilentDeath { get; set; }
		[Ordinal(7)] [RED("grapple")] public CName Grapple { get; set; }
		[Ordinal(8)] [RED("grappleMovement")] public CName GrappleMovement { get; set; }
		[Ordinal(9)] [RED("environmentalKnockdown")] public CName EnvironmentalKnockdown { get; set; }
		[Ordinal(10)] [RED("bump")] public CName Bump { get; set; }
		[Ordinal(11)] [RED("curious")] public CName Curious { get; set; }
		[Ordinal(12)] [RED("fear")] public CName Fear { get; set; }
		[Ordinal(13)] [RED("jump")] public CName Jump { get; set; }
		[Ordinal(14)] [RED("effortLong")] public CName EffortLong { get; set; }
		[Ordinal(15)] [RED("deathShort")] public CName DeathShort { get; set; }
		[Ordinal(16)] [RED("greet")] public CName Greet { get; set; }
		[Ordinal(17)] [RED("laughHard")] public CName LaughHard { get; set; }
		[Ordinal(18)] [RED("laughSoft")] public CName LaughSoft { get; set; }
		[Ordinal(19)] [RED("phone")] public CName Phone { get; set; }
		[Ordinal(20)] [RED("braindanceExcited")] public CName BraindanceExcited { get; set; }
		[Ordinal(21)] [RED("braindanceFearful")] public CName BraindanceFearful { get; set; }
		[Ordinal(22)] [RED("braindanceNeutral")] public CName BraindanceNeutral { get; set; }
		[Ordinal(23)] [RED("braindanceSexual")] public CName BraindanceSexual { get; set; }
		[Ordinal(24)] [RED("contextualVoiceGruntSettings")] public audioContextualVoiceGruntSettings ContextualVoiceGruntSettings { get; set; }
		[Ordinal(25)] [RED("gruntVariations")] public audioVoiceGruntVariations GruntVariations { get; set; }

		public audioGeneralVoiceGruntSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
