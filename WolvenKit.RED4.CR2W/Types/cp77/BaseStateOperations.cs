using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("stateActionsOverrides")] public SGenericDeviceActionsData StateActionsOverrides { get; set; }
		[Ordinal(3)] [RED("baseStateOperations")] public CArray<SBaseStateOperationData> BaseStateOperations_ { get; set; }
		[Ordinal(4)] [RED("wasStateCached")] public CBool WasStateCached { get; set; }
		[Ordinal(5)] [RED("cachedState")] public CEnum<EDeviceStatus> CachedState { get; set; }

		public BaseStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
