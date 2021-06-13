using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualisationRequest : redEvent
	{
		[Ordinal(0)] [RED("areaEffectID")] public CName AreaEffectID { get; set; }
		[Ordinal(1)] [RED("show")] public CBool Show { get; set; }

		public AreaEffectVisualisationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
