using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeContainer : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(3)] [RED("shape")] public CHandle<gameIHitShape> Shape { get; set; }
		[Ordinal(4)] [RED("userData")] public CHandle<gameHitShapeUserData> UserData { get; set; }
		[Ordinal(5)] [RED("physicsMaterial")] public physicsMaterialReference PhysicsMaterial { get; set; }

		public gameHitShapeContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
