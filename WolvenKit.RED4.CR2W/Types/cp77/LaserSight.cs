using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LaserSight : Attack_Beam
	{
		[Ordinal(0)] [RED("previousTarget")] public wCHandle<entEntity> PreviousTarget { get; set; }

		public LaserSight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
