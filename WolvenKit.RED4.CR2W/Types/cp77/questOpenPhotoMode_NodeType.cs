using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOpenPhotoMode_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("factName")] public CString FactName { get; set; }
		[Ordinal(1)] [RED("forceFppMode")] public CBool ForceFppMode { get; set; }
		[Ordinal(2)] [RED("alwaysAllowTPP")] public CBool AlwaysAllowTPP { get; set; }
		[Ordinal(3)] [RED("lockExitUntilScreenshot")] public CBool LockExitUntilScreenshot { get; set; }

		public questOpenPhotoMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
