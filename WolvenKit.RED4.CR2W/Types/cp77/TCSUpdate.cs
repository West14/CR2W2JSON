using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TCSUpdate : gameScriptableSystemRequest
	{
		public TCSUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
