using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MineDispenserPlaceDecisions : MineDispenserTransition
	{
		[Ordinal(0)] [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }
		[Ordinal(1)] [RED("spawnNormal")] public Vector4 SpawnNormal { get; set; }

		public MineDispenserPlaceDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
