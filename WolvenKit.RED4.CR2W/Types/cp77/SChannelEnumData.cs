using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SChannelEnumData : CVariable
	{
		[Ordinal(0)] [RED("channel")] public CEnum<ETVChannel> Channel { get; set; }

		public SChannelEnumData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
