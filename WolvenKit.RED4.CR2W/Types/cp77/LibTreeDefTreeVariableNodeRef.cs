using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableNodeRef : LibTreeDefTreeVariable
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }
		[Ordinal(3)] [RED("defaultValue")] public NodeRef DefaultValue { get; set; }

		public LibTreeDefTreeVariableNodeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
