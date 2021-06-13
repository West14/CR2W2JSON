using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChestPress : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeatureData")] public CHandle<AnimFeature_ChestPress> AnimFeatureData { get; set; }
		[Ordinal(94)] [RED("animFeatureDataName")] public CName AnimFeatureDataName { get; set; }

		public ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
