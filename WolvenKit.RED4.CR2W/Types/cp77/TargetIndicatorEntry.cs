using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetIndicatorEntry : CVariable
	{
		[Ordinal(0)] [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(1)] [RED("indicator")] public wCHandle<inkWidget> Indicator { get; set; }

		public TargetIndicatorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
