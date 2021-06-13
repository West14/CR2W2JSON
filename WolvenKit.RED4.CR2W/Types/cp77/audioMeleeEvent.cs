using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeEvent : CVariable
	{
		[Ordinal(0)] [RED("event")] public CName Event { get; set; }
		[Ordinal(1)] [RED("params")] public CArray<audioAudSimpleParameter> Params { get; set; }

		public audioMeleeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
