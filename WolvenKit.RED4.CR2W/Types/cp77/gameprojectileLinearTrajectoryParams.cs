using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] [RED("startVel")] public CFloat StartVel { get; set; }

		public gameprojectileLinearTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
