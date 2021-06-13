using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("valueToListen")] public CEnum<EMagazineAmmoState> ValueToListen { get; set; }

		public AmmoStateHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
