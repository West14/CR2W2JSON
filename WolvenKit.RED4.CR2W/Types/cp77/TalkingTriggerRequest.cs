using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TalkingTriggerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("isPlayerCalling")] public CBool IsPlayerCalling { get; set; }
		[Ordinal(1)] [RED("contact")] public CName Contact { get; set; }
		[Ordinal(2)] [RED("state")] public CEnum<questPhoneTalkingState> State { get; set; }

		public TalkingTriggerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
