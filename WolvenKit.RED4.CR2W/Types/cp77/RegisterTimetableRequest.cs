using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requesterData")] public PSOwnerData RequesterData { get; set; }
		[Ordinal(1)] [RED("timeTable")] public CArray<SDeviceTimetableEntry> TimeTable { get; set; }
		[Ordinal(2)] [RED("lights")] public CInt32 Lights { get; set; }

		public RegisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
