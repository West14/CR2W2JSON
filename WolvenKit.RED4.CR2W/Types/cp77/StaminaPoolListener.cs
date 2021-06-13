using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaPoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("staminaBar")] public wCHandle<StaminabarWidgetGameController> StaminaBar { get; set; }

		public StaminaPoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
