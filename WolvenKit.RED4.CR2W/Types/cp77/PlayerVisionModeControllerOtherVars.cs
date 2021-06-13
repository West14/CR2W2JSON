using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerOtherVars : CVariable
	{
		[Ordinal(0)] [RED("enabledByToggle")] public CBool EnabledByToggle { get; set; }
		[Ordinal(1)] [RED("active")] public CBool Active { get; set; }

		public PlayerVisionModeControllerOtherVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
