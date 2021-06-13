using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAIBlackboardSerializableID : CVariable
	{
		[Ordinal(0)] [RED("id")] public gameBlackboardSerializableID Id { get; set; }

		public AIAIBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
