using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("broadcastChannel")] public CUInt8 BroadcastChannel { get; set; }
		[Ordinal(2)] [RED("tracks")] public CArray<CName> Tracks { get; set; }

		public audioPlaylistMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
