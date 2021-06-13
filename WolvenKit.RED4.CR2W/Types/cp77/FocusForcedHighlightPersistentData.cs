using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusForcedHighlightPersistentData : IScriptable
	{
		[Ordinal(0)] [RED("sourceID")] public entEntityID SourceID { get; set; }
		[Ordinal(1)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(2)] [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(3)] [RED("outlineType")] public CEnum<EFocusOutlineType> OutlineType { get; set; }
		[Ordinal(4)] [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(5)] [RED("inTransitionTime")] public CFloat InTransitionTime { get; set; }
		[Ordinal(6)] [RED("outTransitionTime")] public CFloat OutTransitionTime { get; set; }
		[Ordinal(7)] [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(8)] [RED("patternType")] public CEnum<gameVisionModePatternType> PatternType { get; set; }

		public FocusForcedHighlightPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
