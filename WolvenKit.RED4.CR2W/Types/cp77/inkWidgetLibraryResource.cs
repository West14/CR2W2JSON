using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResource : CResource
	{
		[Ordinal(1)] [RED("libraryItems")] public CArray<inkWidgetLibraryItem> LibraryItems { get; set; }
		[Ordinal(2)] [RED("externalLibraries")] public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries { get; set; }
		[Ordinal(3)] [RED("animationLibraryResRef")] public raRef<inkanimAnimationLibraryResource> AnimationLibraryResRef { get; set; }
		[Ordinal(4)] [RED("sequences")] public CArray<CHandle<inkanimSequence>> Sequences { get; set; }
		[Ordinal(5)] [RED("rootDefinitionIndex")] public CUInt32 RootDefinitionIndex { get; set; }
		[Ordinal(6)] [RED("externalDependenciesForInternalItems")] public CArray<raRef<CResource>> ExternalDependenciesForInternalItems { get; set; }
		[Ordinal(7)] [RED("rootResolution")] public CEnum<inkETextureResolution> RootResolution { get; set; }
		[Ordinal(8)] [RED("version")] public CEnum<inkWidgetResourceVersion> Version { get; set; }

		public inkWidgetLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
