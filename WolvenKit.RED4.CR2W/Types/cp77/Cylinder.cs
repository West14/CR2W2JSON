using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Cylinder : CVariable
	{
		[Ordinal(0)] [RED("positionAndRadius")] public Vector4 PositionAndRadius { get; set; }
		[Ordinal(1)] [RED("normalAndHeight")] public Vector4 NormalAndHeight { get; set; }

		public Cylinder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
