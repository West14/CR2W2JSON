using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent : ISerializable
	{
		[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
		[Ordinal(1)] [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
		[Ordinal(2)] [RED("eventName")] public CName EventName { get; set; }

		public animAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
