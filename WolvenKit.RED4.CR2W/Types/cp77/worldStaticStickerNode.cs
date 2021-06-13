using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticStickerNode : worldNode
	{
		[Ordinal(4)] [RED("labels")] public CArray<CString> Labels { get; set; }
		[Ordinal(5)] [RED("showBackground")] public CBool ShowBackground { get; set; }
		[Ordinal(6)] [RED("textColor")] public CColor TextColor { get; set; }
		[Ordinal(7)] [RED("backgroundColor")] public CColor BackgroundColor { get; set; }
		[Ordinal(8)] [RED("sprites")] public CArray<raRef<CBitmapTexture>> Sprites { get; set; }
		[Ordinal(9)] [RED("spriteSize")] public CInt32 SpriteSize { get; set; }
		[Ordinal(10)] [RED("alignSpritesHorizontally")] public CBool AlignSpritesHorizontally { get; set; }
		[Ordinal(11)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(12)] [RED("visibilityDistance")] public CFloat VisibilityDistance { get; set; }

		public worldStaticStickerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
