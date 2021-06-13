using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSetBoneTransformEntry : CVariable
	{
		[Ordinal(0)] [RED("transformToChange")] public animTransformIndex TransformToChange { get; set; }
		[Ordinal(1)] [RED("setMethod")] public CEnum<animSetBoneTransformEntry_SetMethod> SetMethod { get; set; }
		[Ordinal(2)] [RED("snapToReference")] public CBool SnapToReference { get; set; }
		[Ordinal(3)] [RED("sourceBone")] public animTransformIndex SourceBone { get; set; }
		[Ordinal(4)] [RED("offsetToReference")] public CBool OffsetToReference { get; set; }
		[Ordinal(5)] [RED("offsetSpaceBone")] public animTransformIndex OffsetSpaceBone { get; set; }
		[Ordinal(6)] [RED("offset")] public QsTransform Offset { get; set; }

		public animSetBoneTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
