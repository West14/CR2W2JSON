using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorObstacleSettings : CVariable
	{
		[Ordinal(0)] [RED("libraryName")] public CName LibraryName { get; set; }
		[Ordinal(1)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(2)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(3)] [RED("segmentOffset")] public CUInt32 SegmentOffset { get; set; }

		public gameuiRoadEditorObstacleSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
