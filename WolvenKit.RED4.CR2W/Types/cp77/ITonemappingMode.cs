using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ITonemappingMode : ISerializable
	{
		[Ordinal(0)] [RED("colorPreservation")] public curveData<CFloat> ColorPreservation { get; set; }

		public ITonemappingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
