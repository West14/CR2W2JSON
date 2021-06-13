using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isTinted")] public CBool IsTinted { get; set; }
		[Ordinal(104)] [RED("useAppearances")] public CBool UseAppearances { get; set; }
		[Ordinal(105)] [RED("clearAppearance")] public CName ClearAppearance { get; set; }
		[Ordinal(106)] [RED("tintedAppearance")] public CName TintedAppearance { get; set; }

		public DisplayGlassControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
