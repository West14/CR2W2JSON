using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterAnimFeature : entAnimInputSetter
	{
		[Ordinal(1)] [RED("value")] public CHandle<animAnimFeature> Value { get; set; }
		[Ordinal(2)] [RED("delay")] public CFloat Delay { get; set; }

		public entAnimInputSetterAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
