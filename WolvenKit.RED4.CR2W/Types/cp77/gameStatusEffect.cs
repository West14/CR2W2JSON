using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffect : gameStatusEffectBase
	{
		[Ordinal(1)] [RED("durationID")] public CUInt32 DurationID { get; set; }
		[Ordinal(2)] [RED("durationModifiers")] public CArray<CHandle<gameStatModifierData>> DurationModifiers { get; set; }
		[Ordinal(3)] [RED("stackModifiers")] public CArray<CHandle<gameStatModifierData>> StackModifiers { get; set; }
		[Ordinal(4)] [RED("removeAllStacksWhenDurationEndsModifiers")] public CArray<CHandle<gameStatModifierData>> RemoveAllStacksWhenDurationEndsModifiers { get; set; }
		[Ordinal(5)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(6)] [RED("remainingDuration")] public CFloat RemainingDuration { get; set; }
		[Ordinal(7)] [RED("maxStacks")] public CUInt32 MaxStacks { get; set; }
		[Ordinal(8)] [RED("sourcesData")] public CArray<gameSourceData> SourcesData { get; set; }
		[Ordinal(9)] [RED("initialApplicationTimestamp")] public CFloat InitialApplicationTimestamp { get; set; }
		[Ordinal(10)] [RED("lastApplicationTimestamp")] public CFloat LastApplicationTimestamp { get; set; }
		[Ordinal(11)] [RED("ownerEntityID")] public entEntityID OwnerEntityID { get; set; }
		[Ordinal(12)] [RED("instigatorRecordID")] public TweakDBID InstigatorRecordID { get; set; }
		[Ordinal(13)] [RED("instigatorEntityID")] public entEntityID InstigatorEntityID { get; set; }
		[Ordinal(14)] [RED("direction")] public Vector4 Direction { get; set; }
		[Ordinal(15)] [RED("removeAllStacksWhenDurationEnds")] public CBool RemoveAllStacksWhenDurationEnds { get; set; }
		[Ordinal(16)] [RED("applicationSource")] public CName ApplicationSource { get; set; }

		public gameStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
