using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerkArea : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataPerkArea> Type { get; set; }
		[Ordinal(1)] [RED("unlocked")] public CBool Unlocked { get; set; }
		[Ordinal(2)] [RED("boughtPerks")] public CArray<SPerk> BoughtPerks { get; set; }

		public SPerkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
