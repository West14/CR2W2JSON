using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioTierEvent : redEvent
	{
		[Ordinal(0)] [RED("radioTier")] public CUInt32 RadioTier { get; set; }
		[Ordinal(1)] [RED("overrideTier")] public CBool OverrideTier { get; set; }

		public VehicleRadioTierEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
