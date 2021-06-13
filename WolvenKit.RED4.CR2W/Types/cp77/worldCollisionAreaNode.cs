using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("material")] public CName Material { get; set; }
		[Ordinal(7)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(8)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public worldCollisionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
