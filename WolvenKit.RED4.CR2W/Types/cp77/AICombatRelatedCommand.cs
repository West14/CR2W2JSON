using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatRelatedCommand : AICommand
	{
		[Ordinal(4)] [RED("immediately")] public CBool Immediately { get; set; }

		public AICombatRelatedCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
