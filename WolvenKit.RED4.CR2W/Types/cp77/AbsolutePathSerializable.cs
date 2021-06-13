using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbsolutePathSerializable : CVariable
	{
		[Ordinal(0)] [RED("Path")] public CString Path { get; set; }

		public AbsolutePathSerializable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
