using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameForceVisionModuleQuestEvent : redEvent
	{
		[Ordinal(0)] [RED("moduleName")] public CName ModuleName { get; set; }
		[Ordinal(1)] [RED("meshComponentNames")] public CArray<CName> MeshComponentNames { get; set; }

		public gameForceVisionModuleQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
