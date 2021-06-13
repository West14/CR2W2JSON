using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsChangedRecord : CVariable
	{
		[Ordinal(0)] [RED("changeInVersion")] public CUInt32 ChangeInVersion { get; set; }
		[Ordinal(1)] [RED("sceneBeforeChange")] public raRef<scnSceneResource> SceneBeforeChange { get; set; }

		public scnScenesVersionsChangedRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
