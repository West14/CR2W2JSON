using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiKillInfo : CVariable
	{
		[Ordinal(0)] [RED("killerEntity")] public wCHandle<gameObject> KillerEntity { get; set; }
		[Ordinal(1)] [RED("victimEntity")] public wCHandle<gameObject> VictimEntity { get; set; }
		[Ordinal(2)] [RED("killType")] public CEnum<gameKillType> KillType { get; set; }

		public gameuiKillInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
