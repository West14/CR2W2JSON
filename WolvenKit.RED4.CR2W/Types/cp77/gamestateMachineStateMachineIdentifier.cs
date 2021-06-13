using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineIdentifier : CVariable
	{
		[Ordinal(0)] [RED("definitionName")] public CName DefinitionName { get; set; }
		[Ordinal(1)] [RED("referenceName")] public CName ReferenceName { get; set; }

		public gamestateMachineStateMachineIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
