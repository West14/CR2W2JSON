using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class gameJournalInternetPage : gameJournalInternetPage_
    {
        [Ordinal(3)] [RED("activatedAtStart")] public CBool ActivatedAtStart { get; set; }

        public gameJournalInternetPage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
