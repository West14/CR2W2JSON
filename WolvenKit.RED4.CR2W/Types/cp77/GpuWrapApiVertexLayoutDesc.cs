using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexLayoutDesc : CVariable
	{
		[Ordinal(0)] [RED("elements", 32)] public CStatic<GpuWrapApiVertexPackingPackingElement> Elements { get; set; }
		[Ordinal(1)] [RED("slotStrides", 8)] public CStatic<CUInt8> SlotStrides { get; set; }
		[Ordinal(2)] [RED("slotMask")] public CUInt32 SlotMask { get; set; }
		[Ordinal(3)] [RED("hash")] public CUInt32 Hash { get; set; }

		public GpuWrapApiVertexLayoutDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
