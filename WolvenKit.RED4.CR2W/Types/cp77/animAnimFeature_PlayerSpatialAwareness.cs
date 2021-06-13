using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerSpatialAwareness : animAnimFeature
	{
		[Ordinal(0)] [RED("leftClosestVector")] public Vector4 LeftClosestVector { get; set; }
		[Ordinal(1)] [RED("rightClosestVector")] public Vector4 RightClosestVector { get; set; }
		[Ordinal(2)] [RED("upHitPosition")] public Vector4 UpHitPosition { get; set; }
		[Ordinal(3)] [RED("forwardDistance")] public CFloat ForwardDistance { get; set; }

		public animAnimFeature_PlayerSpatialAwareness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
