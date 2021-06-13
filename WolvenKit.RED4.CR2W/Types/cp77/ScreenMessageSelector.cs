using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScreenMessageSelector : inkTweakDBIDSelector
	{
		[Ordinal(1)] [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }
		[Ordinal(2)] [RED("customNumber")] public CInt32 CustomNumber { get; set; }

		public ScreenMessageSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
