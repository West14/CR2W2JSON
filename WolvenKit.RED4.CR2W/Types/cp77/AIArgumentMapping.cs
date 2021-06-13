using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentMapping : IScriptable
	{
		[Ordinal(0)] [RED("type")] public CEnum<AIArgumentType> Type { get; set; }
		[Ordinal(1)] [RED("parameterizationType")] public CEnum<AIParameterizationType> ParameterizationType { get; set; }
		[Ordinal(2)] [RED("defaultValue")] public CVariant DefaultValue { get; set; }
		[Ordinal(3)] [RED("prefixValue")] public CHandle<AIArgumentMapping> PrefixValue { get; set; }
		[Ordinal(4)] [RED("customTypeName")] public CName CustomTypeName { get; set; }

		public AIArgumentMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
