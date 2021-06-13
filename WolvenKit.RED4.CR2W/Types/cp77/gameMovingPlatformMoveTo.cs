using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMoveTo : redEvent
	{
		[Ordinal(0)] [RED("movement")] public CHandle<gameIMovingPlatformMovement> Movement { get; set; }
		[Ordinal(1)] [RED("destinationName")] public CName DestinationName { get; set; }
		[Ordinal(2)] [RED("data")] public CInt32 Data { get; set; }

		public gameMovingPlatformMoveTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
