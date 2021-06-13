using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialStatusEffectController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("effectsContainerRef")] public inkCompoundWidgetReference EffectsContainerRef { get; set; }
		[Ordinal(2)] [RED("poolHolderRef")] public inkCompoundWidgetReference PoolHolderRef { get; set; }
		[Ordinal(3)] [RED("effectTemplateRef")] public inkWidgetLibraryReference EffectTemplateRef { get; set; }
		[Ordinal(4)] [RED("maxSize")] public CInt32 MaxSize { get; set; }
		[Ordinal(5)] [RED("effects")] public CArray<wCHandle<SingleCooldownManager>> Effects { get; set; }

		public RadialStatusEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
