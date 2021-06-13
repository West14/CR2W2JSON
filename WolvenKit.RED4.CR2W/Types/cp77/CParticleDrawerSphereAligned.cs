using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerSphereAligned : IParticleDrawer
	{
		[Ordinal(1)] [RED("verticalFixed")] public CBool VerticalFixed { get; set; }
		[Ordinal(2)] [RED("isGPUBased")] public CBool IsGPUBased { get; set; }

		public CParticleDrawerSphereAligned(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
