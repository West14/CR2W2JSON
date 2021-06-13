using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSetParameterOnEmitter : gameaudioeventsEmitterEvent
	{
		[Ordinal(1)] [RED("paramName")] public CName ParamName { get; set; }
		[Ordinal(2)] [RED("paramValue")] public CFloat ParamValue { get; set; }

		public gameaudioeventsSetParameterOnEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
