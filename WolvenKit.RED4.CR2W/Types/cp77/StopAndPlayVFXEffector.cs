using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopAndPlayVFXEffector : gameEffector
	{
		[Ordinal(0)] [RED("vfxToStop")] public CName VfxToStop { get; set; }
		[Ordinal(1)] [RED("vfxToStart")] public CName VfxToStart { get; set; }
		[Ordinal(2)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public StopAndPlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
