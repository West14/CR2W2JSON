using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIContainerEntry : workIEntry
	{
		[Ordinal(2)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
		[Ordinal(3)] [RED("idleAnim")] public CName IdleAnim { get; set; }

		public workIContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
