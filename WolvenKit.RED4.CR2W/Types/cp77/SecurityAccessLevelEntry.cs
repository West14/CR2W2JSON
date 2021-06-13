using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntry : CVariable
	{
		[Ordinal(0)] [RED("keycard")] public TweakDBID Keycard { get; set; }
		[Ordinal(1)] [RED("password")] public CName Password { get; set; }

		public SecurityAccessLevelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
