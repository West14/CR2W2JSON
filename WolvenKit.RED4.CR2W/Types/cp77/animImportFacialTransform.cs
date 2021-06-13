using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialTransform : CVariable
	{
		[Ordinal(0)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(1)] [RED("translation")] public Vector3 Translation { get; set; }
		[Ordinal(2)] [RED("scale")] public Vector3 Scale { get; set; }

		public animImportFacialTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
