using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFppRepDetachedObjectInfo : CVariable
	{
		[Ordinal(0)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)] [RED("itemTDBID")] public TweakDBID ItemTDBID { get; set; }

		public gameFppRepDetachedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
