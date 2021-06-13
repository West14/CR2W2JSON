using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocket : CVariable
	{
		[Ordinal(0)] [RED("stamp")] public scnOutputSocketStamp Stamp { get; set; }
		[Ordinal(1)] [RED("destinations")] public CArray<scnInputSocketId> Destinations { get; set; }

		public scnOutputSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
