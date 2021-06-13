using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_EditorOnlyPredictiveLookAt : animAnimFeature
	{
		[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)] [RED("target")] public Vector4 Target { get; set; }
		[Ordinal(2)] [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(3)] [RED("mode")] public CInt32 Mode { get; set; }

		public animAnimFeature_EditorOnlyPredictiveLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
