using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("throwUnequip")] public gamebbScriptID_Bool ThrowUnequip { get; set; }
		[Ordinal(1)] [RED("lastThrowAngle")] public gamebbScriptID_Float LastThrowAngle { get; set; }
		[Ordinal(2)] [RED("lastThrowPosition")] public gamebbScriptID_Vector4 LastThrowPosition { get; set; }
		[Ordinal(3)] [RED("lastThrowStartType")] public gamebbScriptID_Variant LastThrowStartType { get; set; }

		public CombatGadgetDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
