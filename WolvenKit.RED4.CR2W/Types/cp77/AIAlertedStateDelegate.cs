using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAlertedStateDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("attackInstigatorPosition")] public Vector4 AttackInstigatorPosition { get; set; }

		public AIAlertedStateDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
