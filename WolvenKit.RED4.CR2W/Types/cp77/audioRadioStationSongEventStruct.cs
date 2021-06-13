using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationSongEventStruct : CVariable
	{
		[Ordinal(0)] [RED("radioStationName")] public CName RadioStationName { get; set; }
		[Ordinal(1)] [RED("radioSongName")] public CName RadioSongName { get; set; }

		public audioRadioStationSongEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
