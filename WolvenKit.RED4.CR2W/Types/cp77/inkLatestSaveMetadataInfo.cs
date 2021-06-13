using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLatestSaveMetadataInfo : IScriptable
	{
		[Ordinal(0)] [RED("locationName")] public CString LocationName { get; set; }
		[Ordinal(1)] [RED("trackedQuest")] public CString TrackedQuest { get; set; }
		[Ordinal(2)] [RED("lifePath")] public CEnum<inkLifePath> LifePath { get; set; }
		[Ordinal(3)] [RED("playTime")] public CDouble PlayTime { get; set; }
		[Ordinal(4)] [RED("playthroughTime")] public CDouble PlaythroughTime { get; set; }

		public inkLatestSaveMetadataInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
