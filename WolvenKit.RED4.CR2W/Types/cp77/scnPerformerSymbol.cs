using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPerformerSymbol : CVariable
	{
		[Ordinal(0)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(1)] [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(2)] [RED("editorPerformerId")] public CRUID EditorPerformerId { get; set; }

		public scnPerformerSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
