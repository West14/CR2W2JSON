using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqsResource : CResource
	{
		[Ordinal(1)] [RED("prereqs")] public CArray<gamePrereqDefinition> Prereqs { get; set; }

		public gamePrereqsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
