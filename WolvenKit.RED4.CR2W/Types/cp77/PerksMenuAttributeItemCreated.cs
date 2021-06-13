using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemCreated : redEvent
	{
		[Ordinal(0)] [RED("perksMenuAttributeItem")] public CHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem { get; set; }

		public PerksMenuAttributeItemCreated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
