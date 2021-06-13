using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetVar_NodeType : questIFactsDBManagerNodeType
	{
		[Ordinal(0)] [RED("factName")] public CString FactName { get; set; }
		[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(2)] [RED("setExactValue")] public CBool SetExactValue { get; set; }

		public questSetVar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
