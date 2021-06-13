using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnBeingTarget : redEvent
	{
		[Ordinal(0)] [RED("objectThatTargets")] public wCHandle<gameObject> ObjectThatTargets { get; set; }
		[Ordinal(1)] [RED("noLongerTarget")] public CBool NoLongerTarget { get; set; }

		public OnBeingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
