using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataFileNode : gamedataDataNode
	{
		[Ordinal(3)] [RED("packageName")] public CString PackageName { get; set; }
		[Ordinal(4)] [RED("packageDependencies", 16)] public CStatic<wCHandle<gamedataPackageNode>> PackageDependencies { get; set; }
		[Ordinal(5)] [RED("package")] public wCHandle<gamedataPackageNode> Package { get; set; }
		[Ordinal(6)] [RED("variables")] public CArray<CHandle<gamedataVariableNode>> Variables { get; set; }
		[Ordinal(7)] [RED("groups")] public CArray<CHandle<gamedataGroupNode>> Groups { get; set; }

		public gamedataFileNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
