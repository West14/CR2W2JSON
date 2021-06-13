using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StackTracksExtender : animAnimNode_StackTracksExtender_
    {
        [Ordinal(999)] [RED("shrinkerNodeId")] public CUInt32 ShrinkerNodeId { get; set; }

        public animAnimNode_StackTracksExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
