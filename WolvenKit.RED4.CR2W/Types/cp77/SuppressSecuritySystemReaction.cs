using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressSecuritySystemReaction : redEvent
	{
		[Ordinal(0)] [RED("enableProtection")] public CBool EnableProtection { get; set; }
		[Ordinal(1)] [RED("protectedEntityID")] public entEntityID ProtectedEntityID { get; set; }
		[Ordinal(2)] [RED("entered")] public CBool Entered { get; set; }
		[Ordinal(3)] [RED("hasEntityWithdrawn")] public CBool HasEntityWithdrawn { get; set; }

		public SuppressSecuritySystemReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
