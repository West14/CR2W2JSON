using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalSkinnedMeshComponent : entSkinnedMeshComponent
	{
		[Ordinal(21)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(22)] [RED("useResourceSimulationType")] public CBool UseResourceSimulationType { get; set; }
		[Ordinal(23)] [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(24)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(25)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public entPhysicalSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
