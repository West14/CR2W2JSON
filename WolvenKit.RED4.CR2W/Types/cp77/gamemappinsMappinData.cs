using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)] [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(1)] [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }
		[Ordinal(2)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(3)] [RED("debugCaption")] public CString DebugCaption { get; set; }
		[Ordinal(4)] [RED("localizedCaption")] public LocalizationString LocalizedCaption { get; set; }
		[Ordinal(5)] [RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }
		[Ordinal(6)] [RED("scriptData")] public CHandle<gamemappinsMappinScriptData> ScriptData { get; set; }

		public gamemappinsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
