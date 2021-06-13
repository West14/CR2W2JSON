using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDActorUpdateData : IScriptable
	{
		[Ordinal(0)] [RED("updateVisibility")] public CBool UpdateVisibility { get; set; }
		[Ordinal(1)] [RED("visibilityValue")] public CEnum<ActorVisibilityStatus> VisibilityValue { get; set; }
		[Ordinal(2)] [RED("updateIsRevealed")] public CBool UpdateIsRevealed { get; set; }
		[Ordinal(3)] [RED("isRevealedValue")] public CBool IsRevealedValue { get; set; }
		[Ordinal(4)] [RED("updateIsTagged")] public CBool UpdateIsTagged { get; set; }
		[Ordinal(5)] [RED("isTaggedValue")] public CBool IsTaggedValue { get; set; }
		[Ordinal(6)] [RED("updateClueData")] public CBool UpdateClueData { get; set; }
		[Ordinal(7)] [RED("clueDataValue")] public HUDClueData ClueDataValue { get; set; }
		[Ordinal(8)] [RED("updateIsRemotelyAccessed")] public CBool UpdateIsRemotelyAccessed { get; set; }
		[Ordinal(9)] [RED("isRemotelyAccessedValue")] public CBool IsRemotelyAccessedValue { get; set; }
		[Ordinal(10)] [RED("updateCanOpenScannerInfo")] public CBool UpdateCanOpenScannerInfo { get; set; }
		[Ordinal(11)] [RED("canOpenScannerInfoValue")] public CBool CanOpenScannerInfoValue { get; set; }
		[Ordinal(12)] [RED("updateIsInIconForcedVisibilityRange")] public CBool UpdateIsInIconForcedVisibilityRange { get; set; }
		[Ordinal(13)] [RED("isInIconForcedVisibilityRangeValue")] public CBool IsInIconForcedVisibilityRangeValue { get; set; }
		[Ordinal(14)] [RED("updateIsIconForcedVisibleThroughWalls")] public CBool UpdateIsIconForcedVisibleThroughWalls { get; set; }
		[Ordinal(15)] [RED("isIconForcedVisibleThroughWallsValue")] public CBool IsIconForcedVisibleThroughWallsValue { get; set; }

		public HUDActorUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
