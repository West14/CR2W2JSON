using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CString Id { get; set; }
		[Ordinal(1)] [RED("commandLists")] public CArray<CArray<ElementData>> CommandLists { get; set; }
		[Ordinal(2)] [RED("effects")] public CArray<CEnum<ProgramEffect>> Effects { get; set; }
		[Ordinal(3)] [RED("type")] public CEnum<ProgramType> Type { get; set; }
		[Ordinal(4)] [RED("localizationKey")] public CString LocalizationKey { get; set; }
		[Ordinal(5)] [RED("startAsUnknown")] public CBool StartAsUnknown { get; set; }
		[Ordinal(6)] [RED("wasCompleted")] public CBool WasCompleted { get; set; }

		public ProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
