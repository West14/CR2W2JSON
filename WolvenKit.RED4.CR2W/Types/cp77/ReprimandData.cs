using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandData : CVariable
	{
		[Ordinal(0)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)] [RED("receiver")] public entEntityID Receiver { get; set; }
		[Ordinal(2)] [RED("receiverAttitudeGroup")] public CName ReceiverAttitudeGroup { get; set; }
		[Ordinal(3)] [RED("reprimandID")] public CInt32 ReprimandID { get; set; }
		[Ordinal(4)] [RED("count")] public CInt32 Count { get; set; }

		public ReprimandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
