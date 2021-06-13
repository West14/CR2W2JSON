using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayMappinController : QuestMappinController
	{
		[Ordinal(33)] [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }
		[Ordinal(34)] [RED("isVisibleThroughWalls")] public CBool IsVisibleThroughWalls { get; set; }

		public GameplayMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
