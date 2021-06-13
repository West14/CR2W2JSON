using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAgentSpawnedEvent : redEvent
	{
		[Ordinal(0)] [RED("spawnedAgent")] public DeviceLink SpawnedAgent { get; set; }
		[Ordinal(1)] [RED("eventType")] public CEnum<gameEntitySpawnerEventType> EventType { get; set; }
		[Ordinal(2)] [RED("securityAreas")] public CArray<CHandle<SecurityAreaControllerPS>> SecurityAreas { get; set; }

		public SecurityAgentSpawnedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
