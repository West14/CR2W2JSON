using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_7 : CVariable
	{
		[Ordinal(0)] [RED("var0")] public CInt32 Var0 { get; set; }

		public Sample_Class_2_7(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
