using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuItemDelayedUpdate : redEvent
	{
		public MenuItemDelayedUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
