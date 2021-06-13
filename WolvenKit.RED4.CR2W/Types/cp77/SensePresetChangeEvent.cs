using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensePresetChangeEvent : senseVisibilityEvent
	{
		[Ordinal(4)] [RED("presetID")] public TweakDBID PresetID { get; set; }
		[Ordinal(5)] [RED("mainPreset")] public CBool MainPreset { get; set; }
		[Ordinal(6)] [RED("reset")] public CBool Reset { get; set; }

		public SensePresetChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
