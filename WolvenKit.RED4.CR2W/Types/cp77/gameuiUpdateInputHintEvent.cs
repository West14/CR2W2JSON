using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUpdateInputHintEvent : redEvent
	{
		[Ordinal(0)] [RED("data")] public gameuiInputHintData Data { get; set; }
		[Ordinal(1)] [RED("show")] public CBool Show { get; set; }
		[Ordinal(2)] [RED("targetHintContainer")] public CName TargetHintContainer { get; set; }

		public gameuiUpdateInputHintEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
