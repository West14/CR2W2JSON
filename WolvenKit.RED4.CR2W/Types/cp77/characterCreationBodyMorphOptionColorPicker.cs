using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPicker : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("grid")] public inkUniformGridWidgetReference Grid { get; set; }
		[Ordinal(2)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(3)] [RED("option")] public wCHandle<gameuiCharacterCustomizationOption> Option { get; set; }
		[Ordinal(4)] [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }

		public characterCreationBodyMorphOptionColorPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
