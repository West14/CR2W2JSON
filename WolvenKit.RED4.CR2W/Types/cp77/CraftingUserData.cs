using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingUserData : IScriptable
	{
		[Ordinal(0)] [RED("Mode")] public CEnum<CraftingMode> Mode { get; set; }

		public CraftingUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
