using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		[Ordinal(4)] [RED("defaultMenu")] public CName DefaultMenu { get; set; }
		[Ordinal(5)] [RED("cpoDefaultMenu")] public CName CpoDefaultMenu { get; set; }

		public DebugMenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
