using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
		[Ordinal(12)] [RED("provider")] public CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> Provider { get; set; }

		public animAnimNode_SetDrivenKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
