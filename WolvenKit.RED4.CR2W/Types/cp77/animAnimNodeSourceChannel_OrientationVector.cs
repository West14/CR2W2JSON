using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_OrientationVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(1)] [RED("inputTransformIndex")] public animTransformIndex InputTransformIndex { get; set; }
		[Ordinal(2)] [RED("up")] public Vector3 Up { get; set; }

		public animAnimNodeSourceChannel_OrientationVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
