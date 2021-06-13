using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceDynObjectLogic : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(2)] [RED("minSpawnY")] public CFloat MinSpawnY { get; set; }
		[Ordinal(3)] [RED("maxSpawnY")] public CFloat MaxSpawnY { get; set; }
		[Ordinal(4)] [RED("extraSpeed")] public CFloat ExtraSpeed { get; set; }
		[Ordinal(5)] [RED("availableY")] public CArray<CFloat> AvailableY { get; set; }

		public gameuiRoachRaceDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
