using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsDespawnEntityEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("params")] public scneventsDespawnEntityEventParams Params { get; set; }

		public scneventsDespawnEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
