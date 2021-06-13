using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDoorComponent : entIComponent
	{
		[Ordinal(3)] [RED("interactible")] public CBool Interactible { get; set; }
		[Ordinal(4)] [RED("automatic")] public CBool Automatic { get; set; }
		[Ordinal(5)] [RED("physical")] public CBool Physical { get; set; }
		[Ordinal(6)] [RED("autoOpeningSpeed")] public CFloat AutoOpeningSpeed { get; set; }

		public gameDoorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
