using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathResource : CResource
	{
		[Ordinal(1)] [RED("paths")] public CArray<CHandle<navLocomotionPath>> Paths { get; set; }

		public navLocomotionPathResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
