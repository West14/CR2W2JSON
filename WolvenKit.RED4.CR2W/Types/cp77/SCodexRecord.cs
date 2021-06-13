using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCodexRecord : CVariable
	{
		[Ordinal(0)] [RED("RecordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(1)] [RED("RecordContent")] public CArray<SCodexRecordPart> RecordContent { get; set; }
		[Ordinal(2)] [RED("Tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(3)] [RED("Unlocked")] public CBool Unlocked { get; set; }

		public SCodexRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
