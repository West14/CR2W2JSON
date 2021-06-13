using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleComponentsEvent : redEvent
	{
		[Ordinal(0)] [RED("componentsData")] public CArray<SComponentOperationData> ComponentsData { get; set; }

		public ToggleComponentsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
