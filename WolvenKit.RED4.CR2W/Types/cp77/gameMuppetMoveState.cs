using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetMoveState : CVariable
	{
		[Ordinal(0)] [RED("desiredSpeed")] public CFloat DesiredSpeed { get; set; }
		[Ordinal(1)] [RED("isJumping")] public CBool IsJumping { get; set; }
		[Ordinal(2)] [RED("isFalling")] public CBool IsFalling { get; set; }
		[Ordinal(3)] [RED("isDoubleJumped")] public CBool IsDoubleJumped { get; set; }
		[Ordinal(4)] [RED("moveStyle")] public CEnum<gameMuppetMoveStyle> MoveStyle { get; set; }
		[Ordinal(5)] [RED("jumpStartFrameId")] public CUInt32 JumpStartFrameId { get; set; }
		[Ordinal(6)] [RED("landFrameId")] public CUInt32 LandFrameId { get; set; }

		public gameMuppetMoveState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
