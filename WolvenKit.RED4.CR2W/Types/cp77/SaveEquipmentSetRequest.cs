using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("setName")] public CString SetName { get; set; }
		[Ordinal(2)] [RED("setType")] public CEnum<gameEquipmentSetType> SetType { get; set; }

		public SaveEquipmentSetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
