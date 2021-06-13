using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudMilitechWarningGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(10)] [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }
		[Ordinal(11)] [RED("factListenerId")] public CUInt32 FactListenerId { get; set; }

		public hudMilitechWarningGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
