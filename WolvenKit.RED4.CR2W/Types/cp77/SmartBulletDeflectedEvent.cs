using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartBulletDeflectedEvent : redEvent
	{
		[Ordinal(0)] [RED("localToWorld")] public CMatrix LocalToWorld { get; set; }
		[Ordinal(1)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(2)] [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }

		public SmartBulletDeflectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
