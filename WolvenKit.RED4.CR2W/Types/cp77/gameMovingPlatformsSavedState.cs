using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformsSavedState : ISerializable
	{
		[Ordinal(0)] [RED("mapping")] public CArray<entEntityID> Mapping { get; set; }
		[Ordinal(1)] [RED("data")] public CArray<gameMovingPlatformSavedData> Data { get; set; }

		public gameMovingPlatformsSavedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
