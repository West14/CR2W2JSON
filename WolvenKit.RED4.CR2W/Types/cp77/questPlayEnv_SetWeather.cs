using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_SetWeather : questIEnvironmentManagerNodeType
	{
		[Ordinal(0)] [RED("reset")] public CBool Reset { get; set; }
		[Ordinal(1)] [RED("weatherID")] public TweakDBID WeatherID { get; set; }
		[Ordinal(2)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(3)] [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(4)] [RED("source")] public CName Source { get; set; }

		public questPlayEnv_SetWeather(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
