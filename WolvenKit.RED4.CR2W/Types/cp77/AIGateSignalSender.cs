using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGateSignalSender : AIbehaviortaskStackScript
	{
		[Ordinal(0)] [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(1)] [RED("flags")] public CArray<CEnum<EAIGateSignalFlags>> Flags { get; set; }
		[Ordinal(2)] [RED("priority")] public CFloat Priority { get; set; }

		public AIGateSignalSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
