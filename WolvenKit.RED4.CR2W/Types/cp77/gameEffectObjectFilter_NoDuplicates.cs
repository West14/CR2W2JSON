using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_NoDuplicates : gameEffectObjectGroupFilter
	{
		public gameEffectObjectFilter_NoDuplicates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
