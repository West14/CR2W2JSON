using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialPoseDesc : CVariable
	{
		[Ordinal(0)] [RED("transforms")] public CArray<animImportFacialTransform> Transforms { get; set; }
		[Ordinal(1)] [RED("transformsNoScale")] public CArray<animImportFacialTransformNoScale> TransformsNoScale { get; set; }
		[Ordinal(2)] [RED("transformIds")] public CArray<CUInt16> TransformIds { get; set; }
		[Ordinal(3)] [RED("transformNames")] public CArray<CName> TransformNames { get; set; }

		public animImportFacialPoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
