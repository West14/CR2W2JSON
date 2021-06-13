using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameNotificationData : inkUserData
	{
		[Ordinal(0)] [RED("notificationName")] public CName NotificationName { get; set; }
		[Ordinal(1)] [RED("isBlocking")] public CBool IsBlocking { get; set; }
		[Ordinal(2)] [RED("useCursor")] public CBool UseCursor { get; set; }
		[Ordinal(3)] [RED("queueName")] public CName QueueName { get; set; }
		[Ordinal(4)] [RED("introAnimation")] public CName IntroAnimation { get; set; }
		[Ordinal(5)] [RED("token")] public wCHandle<inkGameNotificationToken> Token { get; set; }

		public inkGameNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
