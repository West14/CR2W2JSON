using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultInt : CVariable
	{
		[Ordinal(0)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(1)] [RED("valid")] public CBool Valid { get; set; }

		public gamestateMachineResultInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
