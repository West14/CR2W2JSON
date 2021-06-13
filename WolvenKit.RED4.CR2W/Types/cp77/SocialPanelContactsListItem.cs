using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsListItem : inkToggleController
	{
		[Ordinal(13)] [RED("Label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(14)] [RED("ContactInfo")] public SocialPanelContactInfo ContactInfo { get; set; }

		public SocialPanelContactsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
