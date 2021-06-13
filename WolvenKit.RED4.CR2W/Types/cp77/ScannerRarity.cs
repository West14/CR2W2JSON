using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerRarity : ScannerChunk
	{
		[Ordinal(0)] [RED("rarity")] public CEnum<gamedataNPCRarity> Rarity { get; set; }
		[Ordinal(1)] [RED("isCivilian")] public CBool IsCivilian { get; set; }

		public ScannerRarity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
