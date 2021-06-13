using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBrush : IScriptable
	{
		[Ordinal(0)] [RED("textureAtlas")] public rRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(1)] [RED("texturePartId")] public CName TexturePartId { get; set; }
		[Ordinal(2)] [RED("tileType")] public CEnum<inkBrushTileType> TileType { get; set; }
		[Ordinal(3)] [RED("mirrorType")] public CEnum<inkBrushMirrorType> MirrorType { get; set; }

		public inkWidgetBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
