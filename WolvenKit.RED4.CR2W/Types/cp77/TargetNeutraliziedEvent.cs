using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNeutraliziedEvent : redEvent
	{
		[Ordinal(0)] [RED("type")] public CEnum<ENeutralizeType> Type { get; set; }
		[Ordinal(1)] [RED("targetID")] public entEntityID TargetID { get; set; }

		public TargetNeutraliziedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
