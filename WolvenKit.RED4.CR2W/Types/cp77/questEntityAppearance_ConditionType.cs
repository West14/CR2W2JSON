using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityAppearance_ConditionType : questIEntityConditionType
	{
		[Ordinal(0)] [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(1)] [RED("appearance")] public CName Appearance { get; set; }

		public questEntityAppearance_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
