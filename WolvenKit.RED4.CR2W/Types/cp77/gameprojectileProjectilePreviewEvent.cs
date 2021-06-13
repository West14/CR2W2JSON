using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileProjectilePreviewEvent : gameprojectileSpawnerPreviewEvent
	{
		[Ordinal(1)] [RED("visualOffset")] public Transform VisualOffset { get; set; }

		public gameprojectileProjectilePreviewEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
