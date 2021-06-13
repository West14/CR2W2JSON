using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioCharacterSystemsManager_NodeType : questIAudioCharacterManager_NodeType
	{
		[Ordinal(0)] [RED("subType")] public CHandle<questIAudioCharacterManager_NodeSubType> SubType { get; set; }

		public questAudioCharacterSystemsManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
