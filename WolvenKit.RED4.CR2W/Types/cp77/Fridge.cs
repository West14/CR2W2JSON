using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Fridge : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }
		[Ordinal(94)] [RED("factOnDoorOpened")] public CName FactOnDoorOpened { get; set; }

		public Fridge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
