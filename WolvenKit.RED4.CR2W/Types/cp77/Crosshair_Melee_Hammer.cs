using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Hammer : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }

		public Crosshair_Melee_Hammer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
