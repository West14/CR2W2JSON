using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerCoverActionState : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }

		public animAnimFeature_PlayerCoverActionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
