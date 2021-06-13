using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereqListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] [RED("state")] public wCHandle<StatusEffectPrereqState> State { get; set; }

		public StatusEffectPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
