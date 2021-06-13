using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverridesColor : CVariable
	{
		[Ordinal(0)] [RED("n")] public CName N { get; set; }
		[Ordinal(1)] [RED("v", 3)] public CArrayFixedSize<CFloat> V { get; set; }

		public Multilayer_LayerTemplateOverridesColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
