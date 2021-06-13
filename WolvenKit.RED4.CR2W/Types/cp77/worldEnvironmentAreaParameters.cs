using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentAreaParameters : CResource
	{
		[Ordinal(1)] [RED("renderAreaSettings")] public WorldRenderAreaSettings RenderAreaSettings { get; set; }
		[Ordinal(2)] [RED("resaved")] public CBool Resaved { get; set; }

		public worldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
