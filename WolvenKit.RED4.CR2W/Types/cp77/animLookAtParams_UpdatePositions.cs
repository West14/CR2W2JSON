using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtParams_UpdatePositions : ISerializable
	{
		public animLookAtParams_UpdatePositions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
