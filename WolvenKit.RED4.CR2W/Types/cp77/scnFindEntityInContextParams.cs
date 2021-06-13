using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInContextParams : CVariable
	{
		[Ordinal(0)] [RED("contextualName")] public CEnum<scnContextualActorName> ContextualName { get; set; }
		[Ordinal(1)] [RED("voiceVagId")] public scnVoicetagId VoiceVagId { get; set; }
		[Ordinal(2)] [RED("contextActorName")] public CName ContextActorName { get; set; }
		[Ordinal(3)] [RED("specRecordId")] public TweakDBID SpecRecordId { get; set; }
		[Ordinal(4)] [RED("forceMaxVisibility")] public CBool ForceMaxVisibility { get; set; }

		public scnFindEntityInContextParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
