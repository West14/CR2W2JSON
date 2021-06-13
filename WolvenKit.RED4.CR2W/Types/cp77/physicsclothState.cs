using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothState : CVariable
	{
		[Ordinal(0)] [RED("verticalPhaseData")] public physicsclothPhaseConfig VerticalPhaseData { get; set; }
		[Ordinal(1)] [RED("horizontalPhaseData")] public physicsclothPhaseConfig HorizontalPhaseData { get; set; }
		[Ordinal(2)] [RED("bendPhaseData")] public physicsclothPhaseConfig BendPhaseData { get; set; }
		[Ordinal(3)] [RED("shearPhaseData")] public physicsclothPhaseConfig ShearPhaseData { get; set; }
		[Ordinal(4)] [RED("runtimeInfo")] public physicsclothRuntimeInfo RuntimeInfo { get; set; }

		public physicsclothState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
