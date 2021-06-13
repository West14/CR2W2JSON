using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCyberspacePixelsortEffectParams : CVariable
	{
		[Ordinal(0)] [RED("fullscreen")] public CBool Fullscreen { get; set; }
		[Ordinal(1)] [RED("vfx")] public CBool Vfx { get; set; }
		[Ordinal(2)] [RED("initialDatamosh")] public CFloat InitialDatamosh { get; set; }
		[Ordinal(3)] [RED("targetDatamosh")] public CFloat TargetDatamosh { get; set; }
		[Ordinal(4)] [RED("initialIntensity")] public CFloat InitialIntensity { get; set; }
		[Ordinal(5)] [RED("targetIntensity")] public CFloat TargetIntensity { get; set; }
		[Ordinal(6)] [RED("timeBlend")] public CFloat TimeBlend { get; set; }

		public gameCyberspacePixelsortEffectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
