using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataDataNode : ISerializable
	{
		[Ordinal(0)] [RED("nodeType")] public CEnum<gamedataDataNodeType> NodeType { get; set; }
		[Ordinal(1)] [RED("fileName")] public CString FileName { get; set; }
		[Ordinal(2)] [RED("parent")] public wCHandle<gamedataDataNode> Parent { get; set; }

		public gamedataDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
