using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimationMotionSample : CVariable
	{
		[Ordinal(0)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(1)] [RED("transform")] public Transform Transform { get; set; }

		public scnAnimationMotionSample(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
