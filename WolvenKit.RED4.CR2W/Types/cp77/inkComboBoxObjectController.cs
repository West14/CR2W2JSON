using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxObjectController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("contentWidgetRef")] public inkWidgetReference ContentWidgetRef { get; set; }
		[Ordinal(2)] [RED("placeholderOffsetWidgetRef")] public inkWidgetReference PlaceholderOffsetWidgetRef { get; set; }
		[Ordinal(3)] [RED("colliderRef")] public inkShapeWidgetReference ColliderRef { get; set; }
		[Ordinal(4)] [RED("offset")] public inkMargin Offset { get; set; }

		public inkComboBoxObjectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
