using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveStrafingTarget : CVariable
	{
		[Ordinal(0)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(1)] [RED("object")] public wCHandle<gameObject> Object { get; set; }

		public moveStrafingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
