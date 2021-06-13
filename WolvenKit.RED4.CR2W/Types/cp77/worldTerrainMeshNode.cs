using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTerrainMeshNode : worldNode
	{
		[Ordinal(4)] [RED("mesh")] public CHandle<CMesh> Mesh { get; set; }
		[Ordinal(5)] [RED("meshRef")] public raRef<CMesh> MeshRef { get; set; }

		public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
