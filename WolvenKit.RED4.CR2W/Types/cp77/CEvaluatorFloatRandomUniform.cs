using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatRandomUniform : IEvaluatorFloat
	{
		[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(1)] [RED("max")] public CFloat Max { get; set; }

		public CEvaluatorFloatRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
