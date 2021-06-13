using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerSetup : TerminalSetup
	{
		[Ordinal(4)] [RED("startingMenu")] public CEnum<EComputerMenuType> StartingMenu { get; set; }
		[Ordinal(5)] [RED("mailsMenu")] public CBool MailsMenu { get; set; }
		[Ordinal(6)] [RED("filesMenu")] public CBool FilesMenu { get; set; }
		[Ordinal(7)] [RED("systemMenu")] public CBool SystemMenu { get; set; }
		[Ordinal(8)] [RED("internetMenu")] public CBool InternetMenu { get; set; }
		[Ordinal(9)] [RED("newsFeedMenu")] public CBool NewsFeedMenu { get; set; }
		[Ordinal(10)] [RED("mailsStructure")] public CArray<gamedeviceGenericDataContent> MailsStructure { get; set; }
		[Ordinal(11)] [RED("filesStructure")] public CArray<gamedeviceGenericDataContent> FilesStructure { get; set; }
		[Ordinal(12)] [RED("newsFeed")] public CArray<SNewsFeedElementData> NewsFeed { get; set; }
		[Ordinal(13)] [RED("newsFeedInterval")] public CFloat NewsFeedInterval { get; set; }
		[Ordinal(14)] [RED("internetSubnet")] public SInternetData InternetSubnet { get; set; }
		[Ordinal(15)] [RED("animationState")] public CEnum<EComputerAnimationState> AnimationState { get; set; }

		public ComputerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
