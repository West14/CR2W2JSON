using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDevice_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)] [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
		[Ordinal(2)] [RED("deviceConditionFunction")] public CName DeviceConditionFunction { get; set; }
		[Ordinal(3)] [RED("functionParameters")] public CArray<questDevice_ConditionFunctionParameter> FunctionParameters { get; set; }

		public questDevice_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
