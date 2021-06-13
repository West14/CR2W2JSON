using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationPersistantElements : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("headerHolder")] public inkCompoundWidgetReference HeaderHolder { get; set; }
		[Ordinal(2)] [RED("LBBtn")] public inkWidgetReference LBBtn { get; set; }
		[Ordinal(3)] [RED("RBBtn")] public inkWidgetReference RBBtn { get; set; }
		[Ordinal(4)] [RED("fluffHolderRight")] public inkCompoundWidgetReference FluffHolderRight { get; set; }
		[Ordinal(5)] [RED("fluffHolderDown")] public inkCompoundWidgetReference FluffHolderDown { get; set; }
		[Ordinal(6)] [RED("fluffHolderLeft")] public inkCompoundWidgetReference FluffHolderLeft { get; set; }
		[Ordinal(7)] [RED("fluffText1")] public inkTextWidgetReference FluffText1 { get; set; }
		[Ordinal(8)] [RED("fluffTextRight")] public inkTextWidgetReference FluffTextRight { get; set; }
		[Ordinal(9)] [RED("fluffTextDown")] public inkTextWidgetReference FluffTextDown { get; set; }
		[Ordinal(10)] [RED("fluffTextLeft")] public inkTextWidgetReference FluffTextLeft { get; set; }
		[Ordinal(11)] [RED("headers")] public CArray<CHandle<CharacterCreationTopBarHeader>> Headers { get; set; }
		[Ordinal(12)] [RED("selectedHeader")] public CHandle<CharacterCreationTopBarHeader> SelectedHeader { get; set; }
		[Ordinal(13)] [RED("c_fluffMaxX")] public CFloat C_fluffMaxX { get; set; }
		[Ordinal(14)] [RED("c_fluffMinY")] public CFloat C_fluffMinY { get; set; }
		[Ordinal(15)] [RED("c_fluffMaxY")] public CFloat C_fluffMaxY { get; set; }

		public CharacterCreationPersistantElements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
