using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStaticTriggerAreaComponent : gameStaticAreaShapeComponent
	{
		[Ordinal(8)] [RED("includeMask")] public CUInt32 IncludeMask { get; set; }
		[Ordinal(9)] [RED("excludeMask")] public CUInt32 ExcludeMask { get; set; }

		public gameStaticTriggerAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
