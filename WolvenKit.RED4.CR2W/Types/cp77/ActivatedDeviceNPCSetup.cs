using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCSetup : CVariable
	{
		[Ordinal(0)] [RED("npcSpawnerNodeRef")] public NodeRef NpcSpawnerNodeRef { get; set; }
		[Ordinal(1)] [RED("npcSpawned")] public wCHandle<NPCPuppet> NpcSpawned { get; set; }

		public ActivatedDeviceNPCSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
