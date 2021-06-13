using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInventoryPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(7)] [RED("sceneName")] public CName SceneName { get; set; }
		[Ordinal(8)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }

		public gameuiInventoryPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
