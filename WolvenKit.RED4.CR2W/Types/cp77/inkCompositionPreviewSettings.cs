using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreviewSettings : ISerializable
	{
		[Ordinal(0)] [RED("sourceState")] public CName SourceState { get; set; }
		[Ordinal(1)] [RED("targetState")] public CName TargetState { get; set; }
		[Ordinal(2)] [RED("previewResolution")] public CEnum<inkETextureResolution> PreviewResolution { get; set; }
		[Ordinal(3)] [RED("gameFrameTexture")] public raRef<CBitmapTexture> GameFrameTexture { get; set; }
		[Ordinal(4)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(5)] [RED("texturePart")] public CName TexturePart { get; set; }

		public inkCompositionPreviewSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
