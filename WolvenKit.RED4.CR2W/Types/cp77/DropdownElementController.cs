using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownElementController : BaseButtonView
	{
		[Ordinal(2)] [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(3)] [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(4)] [RED("frame")] public inkWidgetReference Frame { get; set; }
		[Ordinal(5)] [RED("contentContainer")] public inkWidgetReference ContentContainer { get; set; }
		[Ordinal(6)] [RED("data")] public CHandle<DropdownItemData> Data { get; set; }
		[Ordinal(7)] [RED("active")] public CBool Active { get; set; }

		public DropdownElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
