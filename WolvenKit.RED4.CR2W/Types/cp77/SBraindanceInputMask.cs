using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBraindanceInputMask : CVariable
	{
		[Ordinal(0)] [RED("pauseAction")] public CBool PauseAction { get; set; }
		[Ordinal(1)] [RED("playForwardAction")] public CBool PlayForwardAction { get; set; }
		[Ordinal(2)] [RED("playBackwardAction")] public CBool PlayBackwardAction { get; set; }
		[Ordinal(3)] [RED("restartAction")] public CBool RestartAction { get; set; }
		[Ordinal(4)] [RED("switchLayerAction")] public CBool SwitchLayerAction { get; set; }
		[Ordinal(5)] [RED("cameraToggleAction")] public CBool CameraToggleAction { get; set; }

		public SBraindanceInputMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
