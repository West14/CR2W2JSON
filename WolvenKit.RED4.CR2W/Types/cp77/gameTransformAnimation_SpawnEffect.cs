using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_SpawnEffect : gameTransformAnimation_Effects
	{
		[Ordinal(0)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)] [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(2)] [RED("persistOnDetach")] public CBool PersistOnDetach { get; set; }

		public gameTransformAnimation_SpawnEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
