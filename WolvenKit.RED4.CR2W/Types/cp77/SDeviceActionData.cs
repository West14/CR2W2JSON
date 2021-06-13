using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionData : CVariable
	{
		[Ordinal(0)] [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(1)] [RED("hasUI")] public CBool HasUI { get; set; }
		[Ordinal(2)] [RED("isQuickHack")] public CBool IsQuickHack { get; set; }
		[Ordinal(3)] [RED("isSpiderbotAction")] public CBool IsSpiderbotAction { get; set; }
		[Ordinal(4)] [RED("spiderbotLocationOverrideReference")] public NodeRef SpiderbotLocationOverrideReference { get; set; }
		[Ordinal(5)] [RED("attachedToSkillCheck")] public CEnum<EDeviceChallengeSkill> AttachedToSkillCheck { get; set; }
		[Ordinal(6)] [RED("widgetRecord")] public TweakDBID WidgetRecord { get; set; }
		[Ordinal(7)] [RED("objectActionRecord")] public TweakDBID ObjectActionRecord { get; set; }
		[Ordinal(8)] [RED("currentDisplayName")] public CName CurrentDisplayName { get; set; }
		[Ordinal(9)] [RED("interactionRecord")] public CString InteractionRecord { get; set; }

		public SDeviceActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
