using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundParameter : redEvent
	{
		[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
		[Ordinal(1)] [RED("parameterValue")] public CFloat ParameterValue { get; set; }

		public gameaudioeventsSoundParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
