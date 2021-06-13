using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameter : entEntityParameter
	{
		[Ordinal(0)] [RED("componentsData")] public CArray<entGarmentParameterComponentData> ComponentsData { get; set; }
		[Ordinal(1)] [RED("collarArea")] public garmentCollarAreaParams CollarArea { get; set; }
		[Ordinal(2)] [RED("lastUpdateDateTime")] public CDateTime LastUpdateDateTime { get; set; }

		public entGarmentParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
