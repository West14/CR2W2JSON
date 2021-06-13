using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutAreaOutline : ISerializable
	{
		[Ordinal(0)] [RED("points")] public CArray<CUInt32> Points { get; set; }
		[Ordinal(1)] [RED("edges")] public CArray<CUInt32> Edges { get; set; }

		public worldBlockoutAreaOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
