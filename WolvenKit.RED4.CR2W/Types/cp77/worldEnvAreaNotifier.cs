using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(4)] [RED("horizontalFadeDistance")] public CFloat HorizontalFadeDistance { get; set; }
		[Ordinal(5)] [RED("verticalFadeDistance")] public CFloat VerticalFadeDistance { get; set; }
		[Ordinal(6)] [RED("blendTimeIn")] public CFloat BlendTimeIn { get; set; }
		[Ordinal(7)] [RED("blendTimeOut")] public CFloat BlendTimeOut { get; set; }
		[Ordinal(8)] [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(9)] [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(10)] [RED("weatherStateNames")] public CArray<CName> WeatherStateNames { get; set; }
		[Ordinal(11)] [RED("weatherStateValues")] public CArray<CBool> WeatherStateValues { get; set; }

		public worldEnvAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
