using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkKeyBindingEvent : redEvent
	{
		[Ordinal(0)] [RED("keyName")] public CName KeyName { get; set; }

		public inkKeyBindingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
