using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartRequest : CVariable
	{
		[Ordinal(0)] [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)] [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(3)] [RED("mode")] public CInt32 Mode { get; set; }

		public animLookAtPartRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
