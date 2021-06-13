using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("playerIsIn")] public CBool PlayerIsIn { get; set; }
		[Ordinal(1)] [RED("areaID")] public gamePersistentID AreaID { get; set; }

		public PreventionSecurityAreaRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
