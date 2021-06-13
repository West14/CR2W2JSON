using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
	{
		[Ordinal(28)] [RED("tallImageWidget")] public inkImageWidgetReference TallImageWidget { get; set; }
		[Ordinal(29)] [RED("price")] public CInt32 Price { get; set; }

		public ImageActionButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
