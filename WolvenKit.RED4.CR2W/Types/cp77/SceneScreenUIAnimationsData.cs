using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneScreenUIAnimationsData : IScriptable
	{
		[Ordinal(0)] [RED("customAnimations")] public CHandle<WidgetAnimationManager> CustomAnimations { get; set; }
		[Ordinal(1)] [RED("onSpawnAnimations")] public CArray<CName> OnSpawnAnimations { get; set; }
		[Ordinal(2)] [RED("defaultLibraryItemName")] public CName DefaultLibraryItemName { get; set; }
		[Ordinal(3)] [RED("defaultLibraryItemAnchor")] public CEnum<inkEAnchor> DefaultLibraryItemAnchor { get; set; }

		public SceneScreenUIAnimationsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
