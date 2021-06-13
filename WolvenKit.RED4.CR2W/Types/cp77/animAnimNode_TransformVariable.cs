using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformVariable : animAnimNode_TransformValue
	{
		[Ordinal(11)] [RED("variableName")] public CName VariableName { get; set; }

		public animAnimNode_TransformVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
