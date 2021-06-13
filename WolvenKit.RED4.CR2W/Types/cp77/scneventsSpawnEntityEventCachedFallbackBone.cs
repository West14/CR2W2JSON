using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventCachedFallbackBone : CVariable
	{
		[Ordinal(0)] [RED("boneName")] public CName BoneName { get; set; }
		[Ordinal(1)] [RED("modelSpaceTransform")] public Transform ModelSpaceTransform { get; set; }

		public scneventsSpawnEntityEventCachedFallbackBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
