using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRigMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("positionBones")] public CArray<CName> PositionBones { get; set; }
		[Ordinal(2)] [RED("defaultBone")] public CName DefaultBone { get; set; }

		public audioRigMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
