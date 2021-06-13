using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workFastExit : workIEntry
	{
		[Ordinal(2)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(3)] [RED("forcedBlendIn")] public CFloat ForcedBlendIn { get; set; }
		[Ordinal(4)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }

		public workFastExit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
