using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_MathExpressionPose : animAnimNode_MathExpressionPose_
    {
        [Ordinal(999)] [RED("expressionString")] public CString ExpressionString { get; set; }

        public animAnimNode_MathExpressionPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
