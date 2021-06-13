using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(6)] [RED("shapes")] public CArray<CHandle<gameEnvironmentDamageReceiverShape>> Shapes { get; set; }

		public gameEnvironmentDamageReceiverComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
