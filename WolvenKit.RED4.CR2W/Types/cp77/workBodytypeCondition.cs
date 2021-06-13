using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workBodytypeCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("rig")] public raRef<animRig> Rig { get; set; }

		public workBodytypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
