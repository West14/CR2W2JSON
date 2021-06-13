using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioEventPostedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("audioEvent")] public CName AudioEvent { get; set; }

		public audioAudioEventPostedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
