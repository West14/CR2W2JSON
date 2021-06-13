using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDebugSymbols : CVariable
	{
		[Ordinal(0)] [RED("performersDebugSymbols")] public CArray<scnPerformerSymbol> PerformersDebugSymbols { get; set; }
		[Ordinal(1)] [RED("workspotsDebugSymbols")] public CArray<scnWorkspotSymbol> WorkspotsDebugSymbols { get; set; }
		[Ordinal(2)] [RED("sceneEventsDebugSymbols")] public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols { get; set; }
		[Ordinal(3)] [RED("sceneNodesDebugSymbols")] public CArray<scnNodeSymbol> SceneNodesDebugSymbols { get; set; }

		public scnDebugSymbols(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
