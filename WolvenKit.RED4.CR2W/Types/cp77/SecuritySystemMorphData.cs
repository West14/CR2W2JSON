using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemMorphData : CVariable
	{
		[Ordinal(0)] [RED("state")] public CHandle<State> State { get; set; }
		[Ordinal(1)] [RED("reprimandData")] public CHandle<Reprimand> ReprimandData { get; set; }
		[Ordinal(2)] [RED("blacklist")] public CHandle<Blacklist> Blacklist { get; set; }
		[Ordinal(3)] [RED("protectedEntities")] public CHandle<ProtectedEntities> ProtectedEntities { get; set; }
		[Ordinal(4)] [RED("entitiesAtGate")] public CHandle<EntitiesAtGate> EntitiesAtGate { get; set; }

		public SecuritySystemMorphData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
