using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetVehicleCamera_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("cameraType")] public CEnum<questVehicleCameraType> CameraType { get; set; }
		[Ordinal(1)] [RED("blockOtherCameras")] public CBool BlockOtherCameras { get; set; }

		public questSetVehicleCamera_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
