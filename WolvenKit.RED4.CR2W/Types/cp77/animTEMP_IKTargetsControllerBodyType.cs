using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTEMP_IKTargetsControllerBodyType : CVariable
	{
		[Ordinal(0)] [RED("genderTag")] public CName GenderTag { get; set; }
		[Ordinal(1)] [RED("bodyTypeTag")] public CName BodyTypeTag { get; set; }
		[Ordinal(2)] [RED("ikChainSettings")] public CArray<animIKChainSettings> IkChainSettings { get; set; }

		public animTEMP_IKTargetsControllerBodyType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
