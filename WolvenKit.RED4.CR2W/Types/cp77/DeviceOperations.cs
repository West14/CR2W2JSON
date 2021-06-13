using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperations : IScriptable
	{
		[Ordinal(0)] [RED("components")] public CArray<wCHandle<entIPlacedComponent>> Components { get; set; }
		[Ordinal(1)] [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }

		public DeviceOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
