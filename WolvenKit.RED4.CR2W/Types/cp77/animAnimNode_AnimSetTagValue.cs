using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimSetTagValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("tags")] public redTagList Tags { get; set; }

		public animAnimNode_AnimSetTagValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
