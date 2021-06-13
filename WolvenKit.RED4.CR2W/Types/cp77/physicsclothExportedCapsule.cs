using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothExportedCapsule : CVariable
	{
		[Ordinal(0)] [RED("p0")] public Vector3 P0 { get; set; }
		[Ordinal(1)] [RED("p1")] public Vector3 P1 { get; set; }
		[Ordinal(2)] [RED("r0")] public CFloat R0 { get; set; }
		[Ordinal(3)] [RED("r1")] public CFloat R1 { get; set; }
		[Ordinal(4)] [RED("boneName")] public CName BoneName { get; set; }

		public physicsclothExportedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
