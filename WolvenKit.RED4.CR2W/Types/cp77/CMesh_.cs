using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMesh_ : resStreamedResource
	{
		[Ordinal(2)] [RED("parameters")] public CArray<CHandle<meshMeshParameter>> Parameters { get; set; }
		[Ordinal(3)] [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(4)] [RED("surfaceAreaPerAxis")] public Vector3 SurfaceAreaPerAxis { get; set; }
		[Ordinal(6)] [RED("materialEntries")] public CArray<CMeshMaterialEntry> MaterialEntries { get; set; }
		[Ordinal(7)] [RED("externalMaterials")] public CArray<raRef<IMaterial>> ExternalMaterials { get; set; }
		[Ordinal(8)] [RED("localMaterialInstances")] public CArray<CHandle<CMaterialInstance>> LocalMaterialInstances { get; set; }
		[Ordinal(9)] [RED("localMaterialBuffer")] public meshMeshMaterialBuffer LocalMaterialBuffer { get; set; }
		[Ordinal(10)] [RED("preloadExternalMaterials")] public CArray<rRef<IMaterial>> PreloadExternalMaterials { get; set; }
		[Ordinal(11)] [RED("preloadLocalMaterialInstances")] public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances { get; set; }
		[Ordinal(12)] [RED("appearances")] public CArray<CHandle<meshMeshAppearance>> Appearances { get; set; }
		[Ordinal(13)] [RED("objectType")] public CEnum<ERenderObjectType> ObjectType { get; set; }
		[Ordinal(14)] [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
		[Ordinal(15)] [RED("lodLevelInfo")] public CArray<CFloat> LodLevelInfo { get; set; }
		[Ordinal(16)] [RED("floatTrackNames")] public CArray<CName> FloatTrackNames { get; set; }
		[Ordinal(17)] [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
		[Ordinal(18)] [RED("boneRigMatrices")] public CArray<CMatrix> BoneRigMatrices { get; set; }
		[Ordinal(19)] [RED("boneVertexEpsilons")] public CArray<CFloat> BoneVertexEpsilons { get; set; }
		[Ordinal(20)] [RED("lodBoneMask")] public CArray<CUInt8> LodBoneMask { get; set; }
		[Ordinal(22)] [RED("constrainAutoHideDistanceToTerrainHeightMap")] public CBool ConstrainAutoHideDistanceToTerrainHeightMap { get; set; }
		[Ordinal(23)] [RED("forceLoadAllAppearances")] public CBool ForceLoadAllAppearances { get; set; }
		[Ordinal(24)] [RED("castGlobalShadowsCachedInCook")] public CBool CastGlobalShadowsCachedInCook { get; set; }
		[Ordinal(25)] [RED("castLocalShadowsCachedInCook")] public CBool CastLocalShadowsCachedInCook { get; set; }

		public CMesh_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
