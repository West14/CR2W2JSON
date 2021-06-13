using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateChangedEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("entity")] public entEntityID Entity { get; set; }

		public NameplateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
