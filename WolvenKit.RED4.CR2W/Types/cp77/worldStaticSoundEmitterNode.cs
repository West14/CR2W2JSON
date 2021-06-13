using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticSoundEmitterNode : worldNode
	{
		[Ordinal(4)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(5)] [RED("audioName")] public CName AudioName { get; set; }
		[Ordinal(6)] [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(7)] [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
		[Ordinal(8)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(9)] [RED("acousticRepositioningEnabled")] public CBool AcousticRepositioningEnabled { get; set; }
		[Ordinal(10)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(11)] [RED("useDoppler")] public CBool UseDoppler { get; set; }
		[Ordinal(12)] [RED("dopplerFactor")] public CFloat DopplerFactor { get; set; }
		[Ordinal(13)] [RED("setOpenDoorEmitter")] public CBool SetOpenDoorEmitter { get; set; }
		[Ordinal(14)] [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(15)] [RED("overrideRolloff")] public CBool OverrideRolloff { get; set; }
		[Ordinal(16)] [RED("rolloffOverride")] public CFloat RolloffOverride { get; set; }
		[Ordinal(17)] [RED("ambientPaletteTag")] public CName AmbientPaletteTag { get; set; }

		public worldStaticSoundEmitterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
