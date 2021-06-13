using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LifePathBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] [RED("record")] public CHandle<gamedataLifePath_Record> Record { get; set; }

		public LifePathBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
