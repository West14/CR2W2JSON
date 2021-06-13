using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDialogLineEventData : CVariable
	{
		[Ordinal(0)] [RED("stringId")] public CRUID StringId { get; set; }
		[Ordinal(1)] [RED("context")] public CEnum<locVoiceoverContext> Context { get; set; }
		[Ordinal(2)] [RED("expression")] public CEnum<locVoiceoverExpression> Expression { get; set; }
		[Ordinal(3)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(4)] [RED("isRewind")] public CBool IsRewind { get; set; }
		[Ordinal(5)] [RED("isHolocall")] public CBool IsHolocall { get; set; }
		[Ordinal(6)] [RED("customVoEvent")] public CName CustomVoEvent { get; set; }
		[Ordinal(7)] [RED("seekTime")] public CFloat SeekTime { get; set; }
		[Ordinal(8)] [RED("playbackSpeedParameter")] public CFloat PlaybackSpeedParameter { get; set; }

		public audioDialogLineEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
