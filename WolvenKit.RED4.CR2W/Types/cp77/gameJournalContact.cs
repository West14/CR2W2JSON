using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalContact : gameJournalFileEntry
	{
		[Ordinal(2)] [RED("name")] public LocalizationString Name { get; set; }
		[Ordinal(3)] [RED("avatarID")] public TweakDBID AvatarID { get; set; }
		[Ordinal(4)] [RED("type")] public CEnum<gameContactType> Type { get; set; }
		[Ordinal(5)] [RED("useFlatMessageLayout")] public CBool UseFlatMessageLayout { get; set; }

		public gameJournalContact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
