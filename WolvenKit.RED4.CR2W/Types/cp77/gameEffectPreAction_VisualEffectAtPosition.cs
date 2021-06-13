using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPreAction_VisualEffectAtPosition : gameEffectPreAction
	{
		[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(1)] [RED("attached")] public CBool Attached { get; set; }
		[Ordinal(2)] [RED("breakLoopOnDetach")] public CBool BreakLoopOnDetach { get; set; }
		[Ordinal(3)] [RED("effectTag")] public CName EffectTag { get; set; }

		public gameEffectPreAction_VisualEffectAtPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
