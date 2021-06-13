using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMappingSceneEntry : CVariable
	{
		[Ordinal(0)] [RED("actorVoiceTags")] public CArray<CRUID> ActorVoiceTags { get; set; }
		[Ordinal(1)] [RED("animSets")] public CArray<raRef<animAnimSet>> AnimSets { get; set; }

		public animLipsyncMappingSceneEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
