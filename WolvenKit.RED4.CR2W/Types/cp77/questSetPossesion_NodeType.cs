using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPossesion_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("playerPossesion")] public CEnum<gamedataPlayerPossesion> PlayerPossesion { get; set; }

		public questSetPossesion_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
