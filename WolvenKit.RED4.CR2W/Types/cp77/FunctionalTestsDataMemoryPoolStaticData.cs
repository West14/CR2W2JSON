using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolStaticData : ISerializable
	{
		[Ordinal(0)] [RED("poolName")] public CString PoolName { get; set; }
		[Ordinal(1)] [RED("budget")] public CInt64 Budget { get; set; }
		[Ordinal(2)] [RED("childrenBudget")] public CInt64 ChildrenBudget { get; set; }
		[Ordinal(3)] [RED("children")] public CArray<CString> Children { get; set; }
		[Ordinal(4)] [RED("parent")] public CString Parent { get; set; }

		public FunctionalTestsDataMemoryPoolStaticData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
