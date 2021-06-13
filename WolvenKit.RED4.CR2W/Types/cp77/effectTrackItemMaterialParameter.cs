using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMaterialParameter : effectTrackItem
	{
		[Ordinal(3)] [RED("scale0")] public CFloat Scale0 { get; set; }
		[Ordinal(4)] [RED("customParameter0")] public effectEffectParameterEvaluator CustomParameter0 { get; set; }
		[Ordinal(5)] [RED("scale1")] public CFloat Scale1 { get; set; }
		[Ordinal(6)] [RED("customParameter1")] public effectEffectParameterEvaluator CustomParameter1 { get; set; }
		[Ordinal(7)] [RED("scale2")] public CFloat Scale2 { get; set; }
		[Ordinal(8)] [RED("customParameter2")] public effectEffectParameterEvaluator CustomParameter2 { get; set; }
		[Ordinal(9)] [RED("scale3")] public CFloat Scale3 { get; set; }
		[Ordinal(10)] [RED("customParameter3")] public effectEffectParameterEvaluator CustomParameter3 { get; set; }

		public effectTrackItemMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
