using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiEntityPreviewCameraSettings : CVariable
	{
		[Ordinal(0)] [RED("autoEnable")] public CBool AutoEnable { get; set; }
		[Ordinal(1)] [RED("renderingMode")] public CEnum<ERenderingMode> RenderingMode { get; set; }
		[Ordinal(2)] [RED("panSpeed")] public CFloat PanSpeed { get; set; }
		[Ordinal(3)] [RED("rotationSpeed")] public EulerAngles RotationSpeed { get; set; }
		[Ordinal(4)] [RED("rotationMin")] public EulerAngles RotationMin { get; set; }
		[Ordinal(5)] [RED("rotationMax")] public EulerAngles RotationMax { get; set; }
		[Ordinal(6)] [RED("rotationDefault")] public EulerAngles RotationDefault { get; set; }
		[Ordinal(7)] [RED("zoomSpeed")] public CFloat ZoomSpeed { get; set; }
		[Ordinal(8)] [RED("zoomMin")] public CFloat ZoomMin { get; set; }
		[Ordinal(9)] [RED("zoomMax")] public CFloat ZoomMax { get; set; }
		[Ordinal(10)] [RED("zoomDefault")] public CFloat ZoomDefault { get; set; }

		public gameuiEntityPreviewCameraSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
