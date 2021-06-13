using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageTooltipData : ATooltipData
	{
		[Ordinal(0)] [RED("Title")] public CString Title { get; set; }
		[Ordinal(1)] [RED("Description")] public CString Description { get; set; }
		[Ordinal(2)] [RED("TitleLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage { get; set; }
		[Ordinal(3)] [RED("DescriptionLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage { get; set; }

		public MessageTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
