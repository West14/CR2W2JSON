using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopDialogLine : redEvent
	{
		[Ordinal(0)] [RED("stringId")] public CRUID StringId { get; set; }
		[Ordinal(1)] [RED("fadeOut")] public CFloat FadeOut { get; set; }

		public gameaudioeventsStopDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
