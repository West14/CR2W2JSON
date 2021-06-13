using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDeformableShapesData : meshMeshParameter
	{
		[Ordinal(0)] [RED("ownerIndex")] public CArray<CUInt8> OwnerIndex { get; set; }
		[Ordinal(1)] [RED("startingPose")] public CArray<Transform> StartingPose { get; set; }
		[Ordinal(2)] [RED("finalPose")] public CArray<Transform> FinalPose { get; set; }

		public meshMeshParamDeformableShapesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
