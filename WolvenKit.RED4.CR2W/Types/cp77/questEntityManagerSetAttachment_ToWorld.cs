using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToWorld : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
		[Ordinal(1)] [RED("offsetMode")] public CEnum<questAttachmentOffsetMode> OffsetMode { get; set; }
		[Ordinal(2)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
		[Ordinal(3)] [RED("customOffsetRot")] public Quaternion CustomOffsetRot { get; set; }

		public questEntityManagerSetAttachment_ToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
