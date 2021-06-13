using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceChunkLayer : CVariable
	{
		[Ordinal(0)] [RED("chunks")] public CArray<gameuiRoachRaceChunk> Chunks { get; set; }

		public gameuiRoachRaceChunkLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
