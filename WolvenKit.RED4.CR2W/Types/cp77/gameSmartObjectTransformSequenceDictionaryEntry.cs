using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformSequenceDictionaryEntry : CVariable
	{
		[Ordinal(0)] [RED("sequence")] public CArray<CUInt16> Sequence { get; set; }
		[Ordinal(1)] [RED("id")] public CUInt8 Id { get; set; }

		public gameSmartObjectTransformSequenceDictionaryEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
