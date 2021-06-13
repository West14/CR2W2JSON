using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBannerWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("title")] public CString Title { get; set; }
		[Ordinal(18)] [RED("description")] public CString Description { get; set; }
		[Ordinal(19)] [RED("content")] public redResourceReferenceScriptToken Content { get; set; }

		public SBannerWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
