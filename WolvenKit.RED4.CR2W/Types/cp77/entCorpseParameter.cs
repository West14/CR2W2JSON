using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entCorpseParameter : entEntityParameter
	{
		[Ordinal(0)] [RED("lod")] public CUInt32 Lod { get; set; }
		[Ordinal(1)] [RED("bones")] public CArray<QsTransform> Bones { get; set; }
		[Ordinal(2)] [RED("rigs")] public CArray<raRef<animRig>> Rigs { get; set; }
		[Ordinal(3)] [RED("bakedPose")] public CArray<QsTransform> BakedPose { get; set; }
		[Ordinal(4)] [RED("bakedBoneNames")] public CArray<CName> BakedBoneNames { get; set; }

		public entCorpseParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
