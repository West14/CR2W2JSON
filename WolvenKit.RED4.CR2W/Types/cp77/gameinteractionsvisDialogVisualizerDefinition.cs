using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(1)] [RED("displayNameOverride")] public CString DisplayNameOverride { get; set; }
		[Ordinal(2)] [RED("useLookAt")] public CBool UseLookAt { get; set; }
		[Ordinal(3)] [RED("disableAfterSelectingChoice")] public CBool DisableAfterSelectingChoice { get; set; }
		[Ordinal(4)] [RED("timeProvider")] public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(5)] [RED("hubPriority")] public CUInt8 HubPriority { get; set; }

		public gameinteractionsvisDialogVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
