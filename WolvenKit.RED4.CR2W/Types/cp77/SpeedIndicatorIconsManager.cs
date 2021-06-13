using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("speedIndicator")] public inkImageWidgetReference SpeedIndicator { get; set; }
		[Ordinal(2)] [RED("mirroredSpeedIndicator")] public inkImageWidgetReference MirroredSpeedIndicator { get; set; }

		public SpeedIndicatorIconsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
