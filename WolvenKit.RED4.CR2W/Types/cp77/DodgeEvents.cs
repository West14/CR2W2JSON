using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DodgeEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("blockStatFlag")] public CHandle<gameStatModifierData> BlockStatFlag { get; set; }
		[Ordinal(1)] [RED("decelerationModifier")] public CHandle<gameStatModifierData> DecelerationModifier { get; set; }
		[Ordinal(2)] [RED("pressureWaveCreated")] public CBool PressureWaveCreated { get; set; }

		public DodgeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
