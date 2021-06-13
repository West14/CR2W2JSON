using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)] [RED("hours")] public CInt32 Hours { get; set; }
		[Ordinal(1)] [RED("minutes")] public CInt32 Minutes { get; set; }
		[Ordinal(2)] [RED("seconds")] public CInt32 Seconds { get; set; }
		[Ordinal(3)] [RED("source")] public CName Source { get; set; }

		public questSetTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
