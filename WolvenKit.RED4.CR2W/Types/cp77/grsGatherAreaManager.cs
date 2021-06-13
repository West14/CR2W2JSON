using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsGatherAreaManager : CVariable
	{
		[Ordinal(0)] [RED("activeGatherAreaRepInfo")] public grsGatherAreaReplicatedInfo ActiveGatherAreaRepInfo { get; set; }

		public grsGatherAreaManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
