using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomCentaurBlackboardDef : CustomBlackboardDef
	{
		[Ordinal(0)] [RED("ShieldState")] public gamebbScriptID_Int32 ShieldState { get; set; }
		[Ordinal(1)] [RED("WeakSpotHitTimeStamp")] public gamebbScriptID_Float WeakSpotHitTimeStamp { get; set; }
		[Ordinal(2)] [RED("ShieldTarget")] public gamebbScriptID_EntityID ShieldTarget { get; set; }
		[Ordinal(3)] [RED("WoundedStateHPThreshold")] public gamebbScriptID_Float WoundedStateHPThreshold { get; set; }

		public CustomCentaurBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
