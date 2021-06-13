using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceDefinition : ISerializable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("parentAppearance")] public CName ParentAppearance { get; set; }
		[Ordinal(2)] [RED("partsMasks")] public CArray<CArray<CName>> PartsMasks { get; set; }
		[Ordinal(3)] [RED("partsValues")] public CArray<appearanceAppearancePart> PartsValues { get; set; }
		[Ordinal(4)] [RED("partsOverrides")] public CArray<appearanceAppearancePartOverrides> PartsOverrides { get; set; }
		[Ordinal(5)] [RED("proxyMesh")] public raRef<CMesh> ProxyMesh { get; set; }
		[Ordinal(6)] [RED("forcedLodDistance")] public CUInt8 ForcedLodDistance { get; set; }
		[Ordinal(7)] [RED("proxyMeshAppearance")] public CName ProxyMeshAppearance { get; set; }
		[Ordinal(8)] [RED("cookedDataPathOverride")] public raRef<CResource> CookedDataPathOverride { get; set; }
		[Ordinal(9)] [RED("parametersBuffer")] public entEntityParametersBuffer ParametersBuffer { get; set; }
		[Ordinal(10)] [RED("visualTags")] public redTagList VisualTags { get; set; }
		[Ordinal(11)] [RED("inheritedVisualTags")] public redTagList InheritedVisualTags { get; set; }
		[Ordinal(12)] [RED("hitRepresentationOverrides")] public CArray<gameHitRepresentationOverride> HitRepresentationOverrides { get; set; }
		[Ordinal(13)] [RED("compiledData")] public serializationDeferredDataBuffer CompiledData { get; set; }
		[Ordinal(14)] [RED("resolvedDependencies")] public CArray<raRef<CResource>> ResolvedDependencies { get; set; }
		[Ordinal(15)] [RED("looseDependencies")] public CArray<raRef<CResource>> LooseDependencies { get; set; }
		[Ordinal(16)] [RED("censorFlags")] public CUInt32 CensorFlags { get; set; }

		public appearanceAppearanceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
