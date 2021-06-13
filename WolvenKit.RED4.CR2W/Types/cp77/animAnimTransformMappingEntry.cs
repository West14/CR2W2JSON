using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimTransformMappingEntry : CVariable
	{
		[Ordinal(0)] [RED("from")] public CName From { get; set; }
		[Ordinal(1)] [RED("to")] public CName To { get; set; }

		public animAnimTransformMappingEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
