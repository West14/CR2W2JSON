using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricLight : Device
	{
		[Ordinal(86)] [RED("lightComponents")] public CArray<CHandle<gameLightComponent>> LightComponents { get; set; }
		[Ordinal(87)] [RED("lightDefinitions")] public CArray<gamedataLightPreset> LightDefinitions { get; set; }

		public ElectricLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
