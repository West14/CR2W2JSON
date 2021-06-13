using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTimeDilatable : gameTimeDilatable
	{
		[Ordinal(40)] [RED("listener")] public CHandle<sampleTimeListener> Listener { get; set; }

		public sampleTimeDilatable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
