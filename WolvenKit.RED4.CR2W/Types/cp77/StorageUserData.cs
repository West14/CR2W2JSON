using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StorageUserData : IScriptable
	{
		[Ordinal(0)] [RED("storageObject")] public wCHandle<gameObject> StorageObject { get; set; }

		public StorageUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
