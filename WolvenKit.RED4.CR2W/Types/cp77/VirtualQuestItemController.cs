using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualQuestItemController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("questItem")] public inkWidgetReference QuestItem { get; set; }
		[Ordinal(16)] [RED("data")] public CHandle<VirutalNestedListData> Data { get; set; }

		public VirtualQuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
