using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyCustomGeometryParams : CVariable
	{
		[Ordinal(0)] [RED("useLimiterHelper")] public CBool UseLimiterHelper { get; set; }
		[Ordinal(1)] [RED("uvType")] public CEnum<worldProxyMeshUVType> UvType { get; set; }

		public worldProxyCustomGeometryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
