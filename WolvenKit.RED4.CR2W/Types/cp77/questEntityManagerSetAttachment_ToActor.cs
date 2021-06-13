using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToActor : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
		[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)] [RED("slot")] public CName Slot { get; set; }
		[Ordinal(4)] [RED("offsetMode")] public CEnum<questAttachmentOffsetMode> OffsetMode { get; set; }
		[Ordinal(5)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(6)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public questEntityManagerSetAttachment_ToActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
