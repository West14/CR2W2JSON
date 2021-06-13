using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebuggerProperties : CVariable
	{
		[Ordinal(0)] [RED("exclusiveMode")] public CBool ExclusiveMode { get; set; }
		[Ordinal(1)] [RED("factActivated")] public CName FactActivated { get; set; }
		[Ordinal(2)] [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(3)] [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }

		public DebuggerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
