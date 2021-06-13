using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_OBB : gameHitShapeBase
	{
		[Ordinal(3)] [RED("dimensions")] public Vector3 Dimensions { get; set; }

		public gameHitShape_OBB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
