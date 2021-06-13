using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualItem_TEMP : gameObject
	{
		[Ordinal(40)] [RED("item")] public CString Item { get; set; }
		[Ordinal(41)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(42)] [RED("mesh")] public CHandle<entPhysicalMeshComponent> Mesh { get; set; }
		[Ordinal(43)] [RED("mesh1")] public CHandle<entPhysicalMeshComponent> Mesh1 { get; set; }
		[Ordinal(44)] [RED("mesh2")] public CHandle<entPhysicalMeshComponent> Mesh2 { get; set; }
		[Ordinal(45)] [RED("mesh3")] public CHandle<entPhysicalMeshComponent> Mesh3 { get; set; }
		[Ordinal(46)] [RED("mesh4")] public CHandle<entPhysicalMeshComponent> Mesh4 { get; set; }

		public VirtualItem_TEMP(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
