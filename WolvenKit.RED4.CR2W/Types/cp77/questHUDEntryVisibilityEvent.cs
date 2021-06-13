using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityEvent : CVariable
	{
		[Ordinal(0)] [RED("dataEntries")] public CArray<questHUDEntryVisibilityData> DataEntries { get; set; }

		public questHUDEntryVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
