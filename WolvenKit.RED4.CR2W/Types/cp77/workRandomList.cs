using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workRandomList : workIContainerEntry
	{
		[Ordinal(4)] [RED("minClips")] public CInt8 MinClips { get; set; }
		[Ordinal(5)] [RED("maxClips")] public CInt8 MaxClips { get; set; }
		[Ordinal(6)] [RED("pauseBetweenLength")] public CFloat PauseBetweenLength { get; set; }
		[Ordinal(7)] [RED("pauseLengthDeviation")] public CFloat PauseLengthDeviation { get; set; }
		[Ordinal(8)] [RED("weights")] public CArray<CFloat> Weights { get; set; }
		[Ordinal(9)] [RED("pauseBlendOutTime")] public CFloat PauseBlendOutTime { get; set; }
		[Ordinal(10)] [RED("dontRepeatLastAnims")] public CInt8 DontRepeatLastAnims { get; set; }

		public workRandomList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
