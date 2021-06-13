using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DeviceWorkspot : animAnimFeature
	{
		[Ordinal(0)] [RED("e3_lockInReferencePose")] public CBool E3_lockInReferencePose { get; set; }

		public AnimFeature_DeviceWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
