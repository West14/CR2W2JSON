using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsObjectID : CVariable
	{
		[Ordinal(0)] [RED("entityHash")] public CUInt64 EntityHash { get; set; }
		[Ordinal(1)] [RED("idType")] public CEnum<gameStatIDType> IdType { get; set; }

		public gameStatsObjectID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
