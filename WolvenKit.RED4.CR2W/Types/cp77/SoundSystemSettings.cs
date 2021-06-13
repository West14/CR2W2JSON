using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoundSystemSettings : CVariable
	{
		[Ordinal(0)] [RED("interactionName")] public TweakDBID InteractionName { get; set; }
		[Ordinal(1)] [RED("musicSettings")] public CHandle<MusicSettings> MusicSettings { get; set; }
		[Ordinal(2)] [RED("canBeUsedAsQuickHack")] public CBool CanBeUsedAsQuickHack { get; set; }

		public SoundSystemSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
