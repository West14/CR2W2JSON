using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectVectorEvaluator : ISerializable
	{
		[Ordinal(0)] [RED("modifier")] public CFloat Modifier { get; set; }

		public gameEffectVectorEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
