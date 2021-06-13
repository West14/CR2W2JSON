using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackdoorDataStreamController : BackdoorInkGameController
	{
		[Ordinal(28)] [RED("idleGroup")] public inkWidgetReference IdleGroup_280 { get; set; }
		[Ordinal(29)] [RED("idleVPanelC1")] public inkWidgetReference IdleVPanelC1 { get; set; }
		[Ordinal(30)] [RED("idleVPanelC2")] public inkWidgetReference IdleVPanelC2 { get; set; }
		[Ordinal(31)] [RED("idleVPanelC3")] public inkWidgetReference IdleVPanelC3 { get; set; }
		[Ordinal(32)] [RED("idleVPanelC4")] public inkWidgetReference IdleVPanelC4 { get; set; }
		[Ordinal(33)] [RED("hackedGroup")] public inkWidgetReference HackedGroup { get; set; }
		[Ordinal(34)] [RED("idleCanvas1")] public inkWidgetReference IdleCanvas1 { get; set; }
		[Ordinal(35)] [RED("idleCanvas2")] public inkWidgetReference IdleCanvas2 { get; set; }
		[Ordinal(36)] [RED("idleCanvas3")] public inkWidgetReference IdleCanvas3 { get; set; }
		[Ordinal(37)] [RED("idleCanvas4")] public inkWidgetReference IdleCanvas4 { get; set; }
		[Ordinal(38)] [RED("canvasC1")] public inkWidgetReference CanvasC1 { get; set; }
		[Ordinal(39)] [RED("canvasC2")] public inkWidgetReference CanvasC2 { get; set; }
		[Ordinal(40)] [RED("canvasC3")] public inkWidgetReference CanvasC3 { get; set; }
		[Ordinal(41)] [RED("canvasC4")] public inkWidgetReference CanvasC4 { get; set; }

		public BackdoorDataStreamController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
