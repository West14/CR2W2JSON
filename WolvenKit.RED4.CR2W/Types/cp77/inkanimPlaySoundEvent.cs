using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaySoundEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("soundEventName")] public CName SoundEventName { get; set; }

		public inkanimPlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
