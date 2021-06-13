using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterTrafficRunner : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("onDeactivation")] public CBool OnDeactivation { get; set; }

		public UnregisterTrafficRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
