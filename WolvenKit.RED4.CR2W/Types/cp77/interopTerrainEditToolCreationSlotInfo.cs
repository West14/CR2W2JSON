using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainEditToolCreationSlotInfo : CVariable
	{
		[Ordinal(0)] [RED("scale")] public Vector2 Scale { get; set; }
		[Ordinal(1)] [RED("heightMappingOverrideEnable")] public CBool HeightMappingOverrideEnable { get; set; }
		[Ordinal(2)] [RED("heightMappingMin")] public CFloat HeightMappingMin { get; set; }
		[Ordinal(3)] [RED("heightMappingMax")] public CFloat HeightMappingMax { get; set; }

		public interopTerrainEditToolCreationSlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
