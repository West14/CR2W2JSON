using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineIStateActionDefinition : ISerializable
	{
		public gamestateMachineIStateActionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
