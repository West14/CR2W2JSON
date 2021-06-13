using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceResource : resStreamedResource
	{
		[Ordinal(1)] [RED("baseType")] public CName BaseType { get; set; }
		[Ordinal(2)] [RED("baseEntityType")] public CName BaseEntityType { get; set; }
		[Ordinal(3)] [RED("baseEntity")] public raRef<entEntityTemplate> BaseEntity { get; set; }
		[Ordinal(4)] [RED("partType")] public CName PartType { get; set; }
		[Ordinal(5)] [RED("preset")] public CName Preset { get; set; }
		[Ordinal(6)] [RED("appearances")] public CArray<CHandle<appearanceAppearanceDefinition>> Appearances { get; set; }
		[Ordinal(7)] [RED("censorshipMapping")] public CArray<appearanceCensorshipEntry> CensorshipMapping { get; set; }
		[Ordinal(8)] [RED("commonCookData")] public raRef<appearanceCookedAppearanceData> CommonCookData { get; set; }
		[Ordinal(9)] [RED("Wounds")] public CArray<CHandle<entdismembermentWoundResource>> Wounds { get; set; }
		[Ordinal(10)] [RED("DismEffects")] public CArray<CHandle<entdismembermentEffectResource>> DismEffects { get; set; }
		[Ordinal(11)] [RED("DismWoundConfig")] public entdismembermentWoundsConfigSet DismWoundConfig { get; set; }
		[Ordinal(12)] [RED("proxyPolyCount")] public CInt32 ProxyPolyCount { get; set; }
		[Ordinal(13)] [RED("forceCompileProxy")] public CBool ForceCompileProxy { get; set; }

		public appearanceAppearanceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
