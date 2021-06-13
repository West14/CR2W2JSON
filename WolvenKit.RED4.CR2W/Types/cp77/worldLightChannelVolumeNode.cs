using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLightChannelVolumeNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("channels")] public CEnum<rendLightChannel> Channels { get; set; }
		[Ordinal(7)] [RED("streamingDistanceFactor")] public CFloat StreamingDistanceFactor { get; set; }

		public worldLightChannelVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
