using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskProgressMessage : CVariable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)] [RED("progress")] public CFloat Progress { get; set; }
		[Ordinal(2)] [RED("processingTime")] public CFloat ProcessingTime { get; set; }

		public redTaskProgressMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
