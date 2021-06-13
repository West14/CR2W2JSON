using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyNPCTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("dataTrackingFact")] public CEnum<ENPCTelemetryData> DataTrackingFact { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }

		public ModifyNPCTelemetryVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
