using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileData : CVariable
	{
		[Ordinal(0)] [RED("tileX")] public CInt32 TileX { get; set; }
		[Ordinal(1)] [RED("tileY")] public CInt32 TileY { get; set; }
		[Ordinal(2)] [RED("tileLayer")] public CInt32 TileLayer { get; set; }
		[Ordinal(3)] [RED("tilesBuffer")] public DataBuffer TilesBuffer { get; set; }
		[Ordinal(4)] [RED("agentSize")] public CEnum<NavGenAgentSize> AgentSize { get; set; }
		[Ordinal(5)] [RED("offMeshConnections")] public worldOffMeshConnectionsData OffMeshConnections { get; set; }
		[Ordinal(6)] [RED("regenerable")] public CBool Regenerable { get; set; }

		public worldNavigationTileData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
