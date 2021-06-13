using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsAttemptedChoice : CVariable
	{
		[Ordinal(0)] [RED("choiceIdx")] public CInt32 ChoiceIdx { get; set; }
		[Ordinal(1)] [RED("visualizerType")] public CEnum<gameinteractionsvisEVisualizerType> VisualizerType { get; set; }
		[Ordinal(2)] [RED("isSuccess")] public CBool IsSuccess { get; set; }
		[Ordinal(3)] [RED("choice")] public gameinteractionsChoice Choice { get; set; }

		public gameinteractionsAttemptedChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
