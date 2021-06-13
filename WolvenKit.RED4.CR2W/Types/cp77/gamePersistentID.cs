using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePersistentID : CVariable
	{
		[Ordinal(0)] [RED("entityHash")] public CUInt64 EntityHash { get; set; }
		[Ordinal(1)] [RED("componentName")] public CName ComponentName { get; set; }

		public gamePersistentID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
