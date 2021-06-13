using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tachometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] [RED("rpmValueWidget")] public inkTextWidgetReference RpmValueWidget { get; set; }
		[Ordinal(2)] [RED("rpmGaugeForegroundWidget")] public inkRectangleWidgetReference RpmGaugeForegroundWidget { get; set; }
		[Ordinal(3)] [RED("scaleX")] public CBool ScaleX { get; set; }
		[Ordinal(4)] [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(5)] [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(6)] [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(7)] [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(8)] [RED("rpmMinValue")] public CFloat RpmMinValue { get; set; }

		public tachometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
