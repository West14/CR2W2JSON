using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhonePickUp_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
		[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }

		public questPhonePickUp_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
