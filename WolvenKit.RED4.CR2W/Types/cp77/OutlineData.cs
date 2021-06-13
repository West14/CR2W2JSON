using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineData : CVariable
	{
		[Ordinal(0)] [RED("outlineType")] public CEnum<EOutlineType> OutlineType { get; set; }
		[Ordinal(1)] [RED("outlineStrength")] public CFloat OutlineStrength { get; set; }

		public OutlineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
