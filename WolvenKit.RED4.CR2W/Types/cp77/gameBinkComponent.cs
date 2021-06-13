using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("meshTargetBinding")] public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding { get; set; }
		[Ordinal(9)] [RED("videoPlayerName")] public CName VideoPlayerName { get; set; }
		[Ordinal(10)] [RED("binkResource")] public raRef<Bink> BinkResource { get; set; }
		[Ordinal(11)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(12)] [RED("loopVideo")] public CBool LoopVideo { get; set; }
		[Ordinal(13)] [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
		[Ordinal(14)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public gameBinkComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
