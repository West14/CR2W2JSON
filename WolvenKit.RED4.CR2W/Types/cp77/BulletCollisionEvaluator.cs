using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)] [RED("hasStopped")] public CBool HasStopped { get; set; }
		[Ordinal(1)] [RED("stoppedPosition")] public Vector4 StoppedPosition { get; set; }
		[Ordinal(2)] [RED("weaponParams")] public gameprojectileWeaponParams WeaponParams { get; set; }
		[Ordinal(3)] [RED("isExplodingBullet")] public CBool IsExplodingBullet { get; set; }

		public BulletCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
