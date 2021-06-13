using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceSetup : CVariable
	{
		[Ordinal(0)] [RED("numberOfUses")] public CInt32 NumberOfUses { get; set; }
		[Ordinal(1)] [RED("isBodyRequired")] public CBool IsBodyRequired { get; set; }
		[Ordinal(2)] [RED("actionName")] public TweakDBID ActionName { get; set; }
		[Ordinal(3)] [RED("takedownActionName")] public TweakDBID TakedownActionName { get; set; }
		[Ordinal(4)] [RED("nonlethalTakedownActionName")] public TweakDBID NonlethalTakedownActionName { get; set; }

		public DisposalDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
