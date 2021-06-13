using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalTarot : gameJournalEntry
	{
		[Ordinal(1)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)] [RED("name")] public LocalizationString Name { get; set; }
		[Ordinal(3)] [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(4)] [RED("imagePart")] public CName ImagePart { get; set; }

		public gameJournalTarot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
