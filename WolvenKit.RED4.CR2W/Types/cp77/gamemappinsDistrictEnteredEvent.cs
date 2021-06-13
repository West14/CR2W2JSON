using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("entered")] public CBool Entered { get; set; }
		[Ordinal(1)] [RED("sendNewLocationNotification")] public CBool SendNewLocationNotification { get; set; }
		[Ordinal(2)] [RED("district")] public TweakDBID District { get; set; }

		public gamemappinsDistrictEnteredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
