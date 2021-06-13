using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRadioGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("toggleRefs")] public CArray<inkWidgetReference> ToggleRefs { get; set; }
		[Ordinal(2)] [RED("alwaysToggled")] public CBool AlwaysToggled { get; set; }
		[Ordinal(3)] [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }
		[Ordinal(4)] [RED("ValueChanged")] public inkRadioGroupChangedCallback ValueChanged { get; set; }

		public inkRadioGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
