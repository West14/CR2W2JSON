using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefabNode : worldNode
	{
		[Ordinal(4)] [RED("prefab")] public raRef<worldPrefab> Prefab { get; set; }
		[Ordinal(5)] [RED("instanceData")] public CHandle<worldPrefabInstanceData> InstanceData { get; set; }
		[Ordinal(6)] [RED("enabledVariants")] public CHandle<worldPrefabVariantsList> EnabledVariants { get; set; }
		[Ordinal(7)] [RED("canBeToggledInGame")] public CBool CanBeToggledInGame { get; set; }
		[Ordinal(8)] [RED("noCollision")] public CBool NoCollision { get; set; }
		[Ordinal(9)] [RED("enableRenderSceneLayerOverride")] public CBool EnableRenderSceneLayerOverride { get; set; }
		[Ordinal(10)] [RED("renderSceneLayerMask")] public CEnum<RenderSceneLayerMask> RenderSceneLayerMask { get; set; }
		[Ordinal(11)] [RED("ignoreMeshEmbeddedOccluders")] public CBool IgnoreMeshEmbeddedOccluders { get; set; }
		[Ordinal(12)] [RED("ignoreAllOccluders")] public CBool IgnoreAllOccluders { get; set; }
		[Ordinal(13)] [RED("occluderAutoHideDistanceScale")] public CUInt8 OccluderAutoHideDistanceScale { get; set; }
		[Ordinal(14)] [RED("proxyMeshOnly")] public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly { get; set; }
		[Ordinal(15)] [RED("proxyScaleOverride")] public CBool ProxyScaleOverride { get; set; }
		[Ordinal(16)] [RED("proxyScale")] public Vector3 ProxyScale { get; set; }

		public worldPrefabNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
