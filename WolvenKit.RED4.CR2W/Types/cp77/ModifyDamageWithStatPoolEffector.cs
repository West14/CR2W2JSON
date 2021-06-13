using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithStatPoolEffector : ModifyDamageEffector
	{
		[Ordinal(2)] [RED("statPool")] public CEnum<gamedataStatPoolType> StatPool { get; set; }
		[Ordinal(3)] [RED("poolStatus")] public CString PoolStatus { get; set; }
		[Ordinal(4)] [RED("maxDmg")] public CFloat MaxDmg { get; set; }
		[Ordinal(5)] [RED("refObj")] public CString RefObj { get; set; }

		public ModifyDamageWithStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
