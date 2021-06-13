using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeStruct : CVariable
	{
		[Ordinal(0)] [RED("key")] public CName Key { get; set; }
		[Ordinal(1)] [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }

		public gameNetrunnerPrototypeStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
