using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAttribute : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("statLevel")] public CFloat StatLevel { get; set; }
		[Ordinal(2)] [RED("attributeType")] public CEnum<gamedataStatType> AttributeType { get; set; }

		public SetAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
