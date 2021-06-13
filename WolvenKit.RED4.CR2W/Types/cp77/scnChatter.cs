using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChatter : CVariable
	{
		[Ordinal(0)] [RED("id")] public CUInt16 Id { get; set; }
		[Ordinal(1)] [RED("voicesetComponent")] public wCHandle<scnVoicesetComponent> VoicesetComponent { get; set; }

		public scnChatter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
