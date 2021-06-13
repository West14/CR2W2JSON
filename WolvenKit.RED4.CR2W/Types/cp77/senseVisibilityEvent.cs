using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibilityEvent : redEvent
	{
		[Ordinal(0)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)] [RED("description")] public CName Description { get; set; }
		[Ordinal(3)] [RED("shapeId")] public TweakDBID ShapeId { get; set; }

		public senseVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
