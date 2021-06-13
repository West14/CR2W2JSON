using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotDefinition : CVariable
	{
		[Ordinal(0)] [RED("suppressor")] public CBool Suppressor { get; set; }
		[Ordinal(1)] [RED("layersDefinition")] public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition { get; set; }

		public gameinteractionsCHotSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
