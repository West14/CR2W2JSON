using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] [RED("ctrl")] public wCHandle<BrightnessSettingsGameController> Ctrl { get; set; }

		public BrightnessSettingsVarListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
