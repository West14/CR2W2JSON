using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIKEventData : CVariable
	{
		[Ordinal(0)] [RED("orientation")] public Quaternion Orientation { get; set; }
		[Ordinal(1)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(2)] [RED("chainName")] public CName ChainName { get; set; }
		[Ordinal(3)] [RED("request")] public animIKTargetRequest Request { get; set; }

		public scnIKEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
