using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingEntry : CVariable
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("worldPosition")] public Vector4 WorldPosition { get; set; }
		[Ordinal(2)] [RED("time")] public netTime Time { get; set; }
		[Ordinal(3)] [RED("pingType")] public CEnum<gamedataPingType> PingType { get; set; }
		[Ordinal(4)] [RED("hitObject")] public wCHandle<entEntity> HitObject { get; set; }

		public gamePingEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
