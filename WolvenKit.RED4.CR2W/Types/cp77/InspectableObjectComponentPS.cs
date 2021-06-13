using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("isStarted")] public CBool IsStarted { get; set; }
		[Ordinal(1)] [RED("isFinished")] public CBool IsFinished { get; set; }
		[Ordinal(2)] [RED("listeners")] public CArray<CHandle<questObjectInspectListener>> Listeners { get; set; }

		public InspectableObjectComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
