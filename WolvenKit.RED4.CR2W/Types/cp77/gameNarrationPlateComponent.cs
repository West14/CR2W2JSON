using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNarrationPlateComponent : entIComponent
	{
		[Ordinal(3)] [RED("narrationCaption")] public CName NarrationCaption { get; set; }
		[Ordinal(4)] [RED("narrationText")] public CName NarrationText { get; set; }
		[Ordinal(5)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public gameNarrationPlateComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
