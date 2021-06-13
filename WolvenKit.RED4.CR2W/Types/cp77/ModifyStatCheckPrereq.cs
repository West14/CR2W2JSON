using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatCheckPrereq : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("register")] public CBool Register { get; set; }
		[Ordinal(2)] [RED("statCheckState")] public CHandle<StatCheckPrereqState> StatCheckState { get; set; }

		public ModifyStatCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
