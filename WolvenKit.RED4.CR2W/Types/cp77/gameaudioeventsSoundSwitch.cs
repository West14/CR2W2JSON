using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundSwitch : redEvent
	{
		[Ordinal(0)] [RED("switchName")] public CName SwitchName { get; set; }
		[Ordinal(1)] [RED("switchValue")] public CName SwitchValue { get; set; }

		public gameaudioeventsSoundSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
