using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurveResourceSet : CResource
	{
		[Ordinal(1)] [RED("curveResources")] public CArray<CurveResourceSetEntry> CurveResources { get; set; }

		public CurveResourceSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
