using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEventData : CVariable
	{
		[Ordinal(0)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)] [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(2)] [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(3)] [RED("clipFront")] public CFloat ClipFront { get; set; }
		[Ordinal(4)] [RED("stretch")] public CFloat Stretch { get; set; }
		[Ordinal(5)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(6)] [RED("bodyPartMask")] public CName BodyPartMask { get; set; }

		public scnPlaySkAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
