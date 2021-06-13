using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("gameName")] public CName GameName { get; set; }
		[Ordinal(2)] [RED("startHealth")] public CUInt32 StartHealth { get; set; }
		[Ordinal(3)] [RED("playerLibraryName")] public CName PlayerLibraryName { get; set; }
		[Ordinal(4)] [RED("playerColliderPositionOffset")] public Vector2 PlayerColliderPositionOffset { get; set; }
		[Ordinal(5)] [RED("playerColliderSizeOffset")] public Vector2 PlayerColliderSizeOffset { get; set; }
		[Ordinal(6)] [RED("gameplayRoot")] public inkCompoundWidgetReference GameplayRoot { get; set; }
		[Ordinal(7)] [RED("baseSpeed")] public CFloat BaseSpeed { get; set; }
		[Ordinal(8)] [RED("spawnedListLibraryNames")] public CArray<CName> SpawnedListLibraryNames { get; set; }
		[Ordinal(9)] [RED("isGameRunning")] public CBool IsGameRunning { get; set; }

		public gameuiSideScrollerMiniGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
