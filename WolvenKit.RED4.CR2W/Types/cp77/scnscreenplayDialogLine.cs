using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayDialogLine : CVariable
	{
		[Ordinal(0)] [RED("itemId")] public scnscreenplayItemId ItemId { get; set; }
		[Ordinal(1)] [RED("speaker")] public scnActorId Speaker { get; set; }
		[Ordinal(2)] [RED("addressee")] public scnActorId Addressee { get; set; }
		[Ordinal(3)] [RED("usage")] public scnscreenplayLineUsage Usage { get; set; }
		[Ordinal(4)] [RED("locstringId")] public scnlocLocstringId LocstringId { get; set; }
		[Ordinal(5)] [RED("maleLipsyncAnimationName")] public CName MaleLipsyncAnimationName { get; set; }
		[Ordinal(6)] [RED("femaleLipsyncAnimationName")] public CName FemaleLipsyncAnimationName { get; set; }

		public scnscreenplayDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
