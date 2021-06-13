using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CColor_ : CVariable
	{
		[Ordinal(0)] [RED("Red")] public CUInt8 Red { get; set; }
		[Ordinal(1)] [RED("Green")] public CUInt8 Green { get; set; }
		[Ordinal(2)] [RED("Blue")] public CUInt8 Blue { get; set; }
		[Ordinal(3)] [RED("Alpha")] public CUInt8 Alpha { get; set; }

		public CColor_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
