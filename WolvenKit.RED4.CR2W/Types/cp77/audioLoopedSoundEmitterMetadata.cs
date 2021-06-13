using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLoopedSoundEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("loopSound")] public CName LoopSound { get; set; }

		public audioLoopedSoundEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
