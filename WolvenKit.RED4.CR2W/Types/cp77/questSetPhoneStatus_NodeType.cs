using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneStatus_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] [RED("status")] public CEnum<questPhoneStatus> Status { get; set; }
		[Ordinal(1)] [RED("customStatus")] public CName CustomStatus { get; set; }

		public questSetPhoneStatus_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
