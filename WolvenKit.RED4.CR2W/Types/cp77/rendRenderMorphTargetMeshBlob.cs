using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlob : IRenderResourceBlob
	{
		[Ordinal(0)] [RED("header")] public rendRenderMorphTargetMeshBlobHeader Header { get; set; }
		[Ordinal(1)] [RED("diffsBuffer")] public DataBuffer DiffsBuffer { get; set; }
		[Ordinal(2)] [RED("mappingBuffer")] public DataBuffer MappingBuffer { get; set; }
		[Ordinal(3)] [RED("textureDiffsBuffer")] public serializationDeferredDataBuffer TextureDiffsBuffer { get; set; }
		[Ordinal(4)] [RED("baseBlob")] public CHandle<IRenderResourceBlob> BaseBlob { get; set; }

		public rendRenderMorphTargetMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
