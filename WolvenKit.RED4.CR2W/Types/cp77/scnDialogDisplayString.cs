using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogDisplayString : CVariable
	{
		[Ordinal(0)] [RED("text")] public CString Text { get; set; }
		[Ordinal(1)] [RED("translation")] public CString Translation { get; set; }
		[Ordinal(2)] [RED("preTranslatedText")] public CString PreTranslatedText { get; set; }
		[Ordinal(3)] [RED("postTranslatedText")] public CString PostTranslatedText { get; set; }
		[Ordinal(4)] [RED("language")] public CEnum<scnDialogLineLanguage> Language { get; set; }

		public scnDialogDisplayString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
