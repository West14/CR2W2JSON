using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_BlendMultiple : animAnimNode_BlendMultiple_
    {
        [Ordinal(999)] [RED("debug")] public CBool Debug { get; set; }

        public animAnimNode_BlendMultiple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
