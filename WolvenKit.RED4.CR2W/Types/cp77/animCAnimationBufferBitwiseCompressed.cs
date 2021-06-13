using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCAnimationBufferBitwiseCompressed : animIAnimationBuffer
	{
		[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)] [RED("bones")] public CArray<animSAnimationBufferBitwiseCompressedBoneTrack> Bones { get; set; }
		[Ordinal(2)] [RED("tracks")] public CArray<animSAnimationBufferBitwiseCompressedData> Tracks { get; set; }
		[Ordinal(3)] [RED("data")] public CArray<CInt8> Data { get; set; }
		[Ordinal(4)] [RED("fallbackData")] public CArray<CInt8> FallbackData { get; set; }
		[Ordinal(5)] [RED("deferredData")] public serializationDeferredDataBuffer DeferredData { get; set; }
		[Ordinal(6)] [RED("orientationCompressionMethod")] public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set; }
		[Ordinal(7)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(8)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
		[Ordinal(9)] [RED("dt")] public CFloat Dt { get; set; }
		[Ordinal(10)] [RED("streamingOption")] public CEnum<SAnimationBufferStreamingOption> StreamingOption { get; set; }
		[Ordinal(11)] [RED("nonStreamableBones")] public CUInt32 NonStreamableBones { get; set; }
		[Ordinal(12)] [RED("extraDataNames")] public CArray<CName> ExtraDataNames { get; set; }
		[Ordinal(13)] [RED("numExtraBones")] public CUInt32 NumExtraBones { get; set; }

		public animCAnimationBufferBitwiseCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
