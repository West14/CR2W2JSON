using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCameraCurvesLibrary : entEntity
	{
		[Ordinal(2)] [RED("cameraCurves")] public CArray<rRef<gameCameraCurveSet>> CameraCurves { get; set; }

		public gameCameraCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
