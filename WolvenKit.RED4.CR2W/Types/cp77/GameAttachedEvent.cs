using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameAttachedEvent : redEvent
	{
		[Ordinal(0)] [RED("isGameplayRelevant")] public CBool IsGameplayRelevant { get; set; }
		[Ordinal(1)] [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(2)] [RED("contentScale")] public TweakDBID ContentScale { get; set; }

		public GameAttachedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
