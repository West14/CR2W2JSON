using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseToggleView : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ToggleController")] public wCHandle<inkToggleController> ToggleController { get; set; }
		[Ordinal(2)] [RED("OldState")] public CEnum<inkEToggleState> OldState { get; set; }

		public BaseToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
