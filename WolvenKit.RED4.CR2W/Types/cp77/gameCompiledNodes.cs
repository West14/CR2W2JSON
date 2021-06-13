using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledNodes : ISerializable
	{
		[Ordinal(0)] [RED("compiledSmartObjects")] public CArray<gameCompiledSmartObjectNode> CompiledSmartObjects { get; set; }

		public gameCompiledNodes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
