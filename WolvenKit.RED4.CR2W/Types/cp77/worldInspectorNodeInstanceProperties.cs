using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInspectorNodeInstanceProperties : ISerializable
	{
		[Ordinal(0)] [RED("setupInfo")] public worldCompiledNodeInstanceSetupInfo SetupInfo { get; set; }
		[Ordinal(1)] [RED("meshNode")] public CHandle<worldMeshNode> MeshNode { get; set; }
		[Ordinal(2)] [RED("instancedMeshNode")] public CHandle<worldInstancedMeshNode> InstancedMeshNode { get; set; }
		[Ordinal(3)] [RED("lastObserverDistanceToStreamingPoint")] public CFloat LastObserverDistanceToStreamingPoint { get; set; }
		[Ordinal(4)] [RED("lastObserverDistanceToSecondaryReferencePoint")] public CFloat LastObserverDistanceToSecondaryReferencePoint { get; set; }
		[Ordinal(5)] [RED("renderProxyAddressForDebug")] public CUInt64 RenderProxyAddressForDebug { get; set; }

		public worldInspectorNodeInstanceProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
