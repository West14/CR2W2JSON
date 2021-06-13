using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] [RED("playerMoney")] public CInt32 PlayerMoney { get; set; }
		[Ordinal(3)] [RED("paymentMoney")] public CInt32 PaymentMoney { get; set; }

		public PaymentBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
