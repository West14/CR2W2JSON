using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverShape : ISerializable
	{
		[Ordinal(0)] [RED("transform")] public Transform Transform { get; set; }

		public gameEnvironmentDamageReceiverShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
