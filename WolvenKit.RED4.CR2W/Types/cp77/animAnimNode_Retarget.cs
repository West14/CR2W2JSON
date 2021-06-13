using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("refRig")] public rRef<animRig> RefRig { get; set; }
		[Ordinal(13)] [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }

		public animAnimNode_Retarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
