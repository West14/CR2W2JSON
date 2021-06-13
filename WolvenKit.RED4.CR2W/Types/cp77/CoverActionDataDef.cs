using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverActionDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("coverActionStateId")] public gamebbScriptID_Int32 CoverActionStateId { get; set; }
		[Ordinal(1)] [RED("playerNearValidEdge")] public gamebbScriptID_Bool PlayerNearValidEdge { get; set; }
		[Ordinal(2)] [RED("debugLeaning")] public gamebbScriptID_Bool DebugLeaning { get; set; }
		[Ordinal(3)] [RED("debugAutoLeaning")] public gamebbScriptID_Bool DebugAutoLeaning { get; set; }
		[Ordinal(4)] [RED("debugDpadLeaning")] public gamebbScriptID_Bool DebugDpadLeaning { get; set; }
		[Ordinal(5)] [RED("debugLsLeaning")] public gamebbScriptID_Bool DebugLsLeaning { get; set; }
		[Ordinal(6)] [RED("debugStagesLeaning")] public gamebbScriptID_Bool DebugStagesLeaning { get; set; }
		[Ordinal(7)] [RED("debugAdsLeaning")] public gamebbScriptID_Bool DebugAdsLeaning { get; set; }

		public CoverActionDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
