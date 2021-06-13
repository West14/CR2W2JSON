using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorBalance : CVariable
	{
		[Ordinal(0)] [RED("Red")] public CFloat Red { get; set; }
		[Ordinal(1)] [RED("Green")] public CFloat Green { get; set; }
		[Ordinal(2)] [RED("Blue")] public CFloat Blue { get; set; }
		[Ordinal(3)] [RED("Luminance")] public CFloat Luminance { get; set; }

		public ColorBalance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
