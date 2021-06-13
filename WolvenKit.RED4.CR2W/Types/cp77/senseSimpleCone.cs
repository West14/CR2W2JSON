using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleCone : senseIShape
	{
		[Ordinal(1)] [RED("position1")] public Vector4 Position1 { get; set; }
		[Ordinal(2)] [RED("position2")] public Vector4 Position2 { get; set; }
		[Ordinal(3)] [RED("radius1")] public CFloat Radius1 { get; set; }
		[Ordinal(4)] [RED("radius2")] public CFloat Radius2 { get; set; }

		public senseSimpleCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
