using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEventData : CVariable
	{
		[Ordinal(0)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(1)] [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }

		public scnLookAtAdvancedEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
