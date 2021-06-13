using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePathElement : CVariable
	{
		[Ordinal(0)] [RED("prefab")] public CString Prefab { get; set; }
		[Ordinal(1)] [RED("nodeID")] public CUInt64 NodeID { get; set; }

		public worldRelativeNodePathElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
