using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerSpotted : redEvent
	{
		[Ordinal(0)] [RED("comesFromNPC")] public CBool ComesFromNPC { get; set; }
		[Ordinal(1)] [RED("ownerID")] public gamePersistentID OwnerID { get; set; }
		[Ordinal(2)] [RED("doesSee")] public CBool DoesSee { get; set; }
		[Ordinal(3)] [RED("agentAreas")] public CArray<CHandle<SecurityAreaControllerPS>> AgentAreas { get; set; }

		public PlayerSpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
