using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendScreenshotBatchData : CVariable
	{
		[Ordinal(0)] [RED("batchPositionsPath")] public AbsolutePathSerializable BatchPositionsPath { get; set; }
		[Ordinal(1)] [RED("delayTime")] public CFloat DelayTime { get; set; }
		[Ordinal(2)] [RED("numberOfCoordinatesToDump")] public CUInt32 NumberOfCoordinatesToDump { get; set; }

		public rendScreenshotBatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
