using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensesOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("sensesOperations")] public CArray<SSensesOperationData> SensesOperations_ { get; set; }

		public SensesOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
