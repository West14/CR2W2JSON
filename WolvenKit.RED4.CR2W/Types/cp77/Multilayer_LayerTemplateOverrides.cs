using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverrides : CVariable
	{
		[Ordinal(0)] [RED("colorScale")] public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale { get; set; }
		[Ordinal(1)] [RED("roughLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn { get; set; }
		[Ordinal(2)] [RED("roughLevelsOut")] public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsOut { get; set; }
		[Ordinal(3)] [RED("metalLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn { get; set; }
		[Ordinal(4)] [RED("metalLevelsOut")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut { get; set; }
		[Ordinal(5)] [RED("normalStrength")] public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength { get; set; }

		public Multilayer_LayerTemplateOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
