using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioEventMetadata : ISerializable
	{
		[Ordinal(0)] [RED("wwiseId")] public CUInt32 WwiseId { get; set; }
		[Ordinal(1)] [RED("maxAttenuation")] public CFloat MaxAttenuation { get; set; }
		[Ordinal(2)] [RED("minDuration")] public CFloat MinDuration { get; set; }
		[Ordinal(3)] [RED("maxDuration")] public CFloat MaxDuration { get; set; }
		[Ordinal(4)] [RED("isLooping")] public CBool IsLooping { get; set; }
		[Ordinal(5)] [RED("stopActionEvents")] public CArray<CName> StopActionEvents { get; set; }
		[Ordinal(6)] [RED("tags")] public CArray<CName> Tags { get; set; }

		public audioAudioEventMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
