using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLogger : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("showStackTransformsCount")] public CBool ShowStackTransformsCount { get; set; }
		[Ordinal(2)] [RED("showStackTracksCount")] public CBool ShowStackTracksCount { get; set; }
		[Ordinal(3)] [RED("entries")] public CArray<CHandle<animPoseInfoLoggerEntry>> Entries { get; set; }

		public animPoseInfoLogger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
