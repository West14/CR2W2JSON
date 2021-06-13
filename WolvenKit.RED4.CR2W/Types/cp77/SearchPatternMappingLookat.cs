using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SearchPatternMappingLookat : AISearchingLookat
	{
		[Ordinal(14)] [RED("targetObjectMapping")] public CHandle<AIArgumentMapping> TargetObjectMapping { get; set; }
		[Ordinal(15)] [RED("lookatTargetObject")] public wCHandle<gameObject> LookatTargetObject { get; set; }

		public SearchPatternMappingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
