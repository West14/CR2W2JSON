using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AppearanceRandomizerComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("appearances")] public CArray<CName> Appearances { get; set; }
		[Ordinal(6)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public AppearanceRandomizerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
