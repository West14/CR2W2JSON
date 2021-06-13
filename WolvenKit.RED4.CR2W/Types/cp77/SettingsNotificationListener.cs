using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsNotificationListener : userSettingsNotificationListener
	{
		[Ordinal(0)] [RED("ctrl")] public wCHandle<SettingsMainGameController> Ctrl { get; set; }

		public SettingsNotificationListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
