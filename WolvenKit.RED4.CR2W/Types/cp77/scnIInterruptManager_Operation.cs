using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIInterruptManager_Operation : ISerializable
	{
		public scnIInterruptManager_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
