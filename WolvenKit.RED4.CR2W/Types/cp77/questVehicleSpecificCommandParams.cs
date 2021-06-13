using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpecificCommandParams : ISerializable
	{
		[Ordinal(0)] [RED("pushOtherVehiclesAside")] public CBool PushOtherVehiclesAside { get; set; }
		[Ordinal(1)] [RED("needDriver")] public CBool NeedDriver { get; set; }
		[Ordinal(2)] [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }

		public questVehicleSpecificCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
