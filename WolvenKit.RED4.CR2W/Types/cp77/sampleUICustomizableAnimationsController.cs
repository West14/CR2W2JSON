using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUICustomizableAnimationsController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("imagePath")] public CName ImagePath { get; set; }
		[Ordinal(2)] [RED("interpolationType")] public CEnum<inkanimInterpolationType> InterpolationType { get; set; }
		[Ordinal(3)] [RED("interpolationMode")] public CEnum<inkanimInterpolationMode> InterpolationMode { get; set; }
		[Ordinal(4)] [RED("delayTime")] public CFloat DelayTime { get; set; }
		[Ordinal(5)] [RED("rotation_anim")] public CHandle<inkanimDefinition> Rotation_anim { get; set; }
		[Ordinal(6)] [RED("size_anim")] public CHandle<inkanimDefinition> Size_anim { get; set; }
		[Ordinal(7)] [RED("color_anim")] public CHandle<inkanimDefinition> Color_anim { get; set; }
		[Ordinal(8)] [RED("alpha_anim")] public CHandle<inkanimDefinition> Alpha_anim { get; set; }
		[Ordinal(9)] [RED("position_anim")] public CHandle<inkanimDefinition> Position_anim { get; set; }
		[Ordinal(10)] [RED("imageWidget")] public wCHandle<inkWidget> ImageWidget { get; set; }
		[Ordinal(11)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(12)] [RED("CanRotate")] public CBool CanRotate { get; set; }
		[Ordinal(13)] [RED("CanResize")] public CBool CanResize { get; set; }
		[Ordinal(14)] [RED("CanChangeColor")] public CBool CanChangeColor { get; set; }
		[Ordinal(15)] [RED("CanChangeAlpha")] public CBool CanChangeAlpha { get; set; }
		[Ordinal(16)] [RED("CanMove")] public CBool CanMove { get; set; }
		[Ordinal(17)] [RED("defaultSize")] public Vector2 DefaultSize { get; set; }
		[Ordinal(18)] [RED("defaultMargin")] public inkMargin DefaultMargin { get; set; }
		[Ordinal(19)] [RED("defaultRotation")] public CFloat DefaultRotation { get; set; }
		[Ordinal(20)] [RED("defaultColor")] public HDRColor DefaultColor { get; set; }
		[Ordinal(21)] [RED("defaultAlpha")] public CFloat DefaultAlpha { get; set; }
		[Ordinal(22)] [RED("isHighlighted")] public CBool IsHighlighted { get; set; }
		[Ordinal(23)] [RED("currentTarget")] public wCHandle<inkWidget> CurrentTarget { get; set; }
		[Ordinal(24)] [RED("currentAnimProxy")] public CHandle<inkanimProxy> CurrentAnimProxy { get; set; }

		public sampleUICustomizableAnimationsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
