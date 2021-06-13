using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnToggleInterruption_InterruptionOperation : scnIInterruptionOperation
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }

		public scnToggleInterruption_InterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
