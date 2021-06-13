using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class populationSpawnModifier : populationModifier
	{
		[Ordinal(0)] [RED("spawnParameter")] public CHandle<gameObjectSpawnParameter> SpawnParameter { get; set; }

		public populationSpawnModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
