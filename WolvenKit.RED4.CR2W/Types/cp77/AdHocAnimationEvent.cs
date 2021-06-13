using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdHocAnimationEvent : redEvent
	{
		[Ordinal(0)] [RED("animationIndex")] public CInt32 AnimationIndex { get; set; }
		[Ordinal(1)] [RED("useBothHands")] public CBool UseBothHands { get; set; }
		[Ordinal(2)] [RED("unequipWeapon")] public CBool UnequipWeapon { get; set; }

		public AdHocAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
