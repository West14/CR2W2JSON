using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDismemberedBodyPartEvent : redEvent
	{
		[Ordinal(0)] [RED("bones", 32)] public CStatic<CName> Bones { get; set; }

		public entDismemberedBodyPartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
