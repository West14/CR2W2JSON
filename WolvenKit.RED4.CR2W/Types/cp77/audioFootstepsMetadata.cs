using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepsMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("defaultFootwearMetadata")] public CName DefaultFootwearMetadata { get; set; }
		[Ordinal(2)] [RED("footwearMetadataArray")] public CArray<CName> FootwearMetadataArray { get; set; }
		[Ordinal(3)] [RED("slideEvent")] public CName SlideEvent { get; set; }
		[Ordinal(4)] [RED("onEnterSound")] public CName OnEnterSound { get; set; }
		[Ordinal(5)] [RED("onExitSound")] public CName OnExitSound { get; set; }

		public audioFootstepsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
