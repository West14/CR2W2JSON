using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerCover : animAnimFeature
	{
		[Ordinal(0)] [RED("cameraPositionMS")] public Vector4 CameraPositionMS { get; set; }
		[Ordinal(1)] [RED("coverState")] public CInt32 CoverState { get; set; }
		[Ordinal(2)] [RED("leanAmount")] public CFloat LeanAmount { get; set; }
		[Ordinal(3)] [RED("cameraOffsetAmount")] public CFloat CameraOffsetAmount { get; set; }
		[Ordinal(4)] [RED("autoCoverActivationFrame")] public CBool AutoCoverActivationFrame { get; set; }

		public animAnimFeature_PlayerCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
