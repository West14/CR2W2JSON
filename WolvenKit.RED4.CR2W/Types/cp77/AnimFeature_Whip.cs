using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Whip : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("pullState")] public CInt32 PullState { get; set; }
		[Ordinal(2)] [RED("targetPoint")] public Vector4 TargetPoint { get; set; }

		public AnimFeature_Whip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
