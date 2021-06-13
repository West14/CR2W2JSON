using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceComponentPS : SharedGameplayPS
	{
		[Ordinal(21)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(22)] [RED("forceResolveStateOnAttach")] public CBool ForceResolveStateOnAttach { get; set; }
		[Ordinal(23)] [RED("forceVisibilityInAnimSystemOnLogicReady")] public CBool ForceVisibilityInAnimSystemOnLogicReady { get; set; }
		[Ordinal(24)] [RED("masters")] public CArray<CHandle<gameDeviceComponentPS>> Masters { get; set; }
		[Ordinal(25)] [RED("mastersCached")] public CBool MastersCached { get; set; }
		[Ordinal(26)] [RED("deviceName")] public CString DeviceName { get; set; }
		[Ordinal(27)] [RED("activationState")] public CEnum<EActivationState> ActivationState { get; set; }
		[Ordinal(28)] [RED("drawGridLink")] public CBool DrawGridLink { get; set; }
		[Ordinal(29)] [RED("isLinkDynamic")] public CBool IsLinkDynamic { get; set; }
		[Ordinal(30)] [RED("fullDepth")] public CBool FullDepth { get; set; }
		[Ordinal(31)] [RED("virtualNetworkShapeID")] public TweakDBID VirtualNetworkShapeID { get; set; }
		[Ordinal(32)] [RED("tweakDBRecord")] public TweakDBID TweakDBRecord { get; set; }
		[Ordinal(33)] [RED("tweakDBDescriptionRecord")] public TweakDBID TweakDBDescriptionRecord { get; set; }
		[Ordinal(34)] [RED("contentScale")] public TweakDBID ContentScale { get; set; }
		[Ordinal(35)] [RED("skillCheckContainer")] public CHandle<BaseSkillCheckContainer> SkillCheckContainer { get; set; }
		[Ordinal(36)] [RED("hasUICameraZoom")] public CBool HasUICameraZoom { get; set; }
		[Ordinal(37)] [RED("allowUICameraZoomDynamicSwitch")] public CBool AllowUICameraZoomDynamicSwitch { get; set; }
		[Ordinal(38)] [RED("hasFullScreenUI")] public CBool HasFullScreenUI { get; set; }
		[Ordinal(39)] [RED("hasAuthorizationModule")] public CBool HasAuthorizationModule { get; set; }
		[Ordinal(40)] [RED("hasPersonalLinkSlot")] public CBool HasPersonalLinkSlot { get; set; }
		[Ordinal(41)] [RED("backdoorBreachDifficulty")] public CEnum<EGameplayChallengeLevel> BackdoorBreachDifficulty { get; set; }
		[Ordinal(42)] [RED("shouldSkipNetrunnerMinigame")] public CBool ShouldSkipNetrunnerMinigame { get; set; }
		[Ordinal(43)] [RED("minigameDefinition")] public TweakDBID MinigameDefinition { get; set; }
		[Ordinal(44)] [RED("minigameAttempt")] public CInt32 MinigameAttempt { get; set; }
		[Ordinal(45)] [RED("hackingMinigameState")] public CEnum<gameuiHackingMinigameState> HackingMinigameState { get; set; }
		[Ordinal(46)] [RED("disablePersonalLinkAutoDisconnect")] public CBool DisablePersonalLinkAutoDisconnect { get; set; }
		[Ordinal(47)] [RED("canHandleAdvancedInteraction")] public CBool CanHandleAdvancedInteraction { get; set; }
		[Ordinal(48)] [RED("canBeTrapped")] public CBool CanBeTrapped { get; set; }
		[Ordinal(49)] [RED("disassembleProperties")] public DisassembleOptions DisassembleProperties { get; set; }
		[Ordinal(50)] [RED("flatheadScavengeProperties")] public SpiderbotScavengeOptions FlatheadScavengeProperties { get; set; }
		[Ordinal(51)] [RED("destructionProperties")] public DestructionData DestructionProperties { get; set; }
		[Ordinal(52)] [RED("canPlayerTakeOverControl")] public CBool CanPlayerTakeOverControl { get; set; }
		[Ordinal(53)] [RED("canBeInDeviceChain")] public CBool CanBeInDeviceChain { get; set; }
		[Ordinal(54)] [RED("personalLinkForced")] public CBool PersonalLinkForced { get; set; }
		[Ordinal(55)] [RED("personalLinkCustomInteraction")] public TweakDBID PersonalLinkCustomInteraction { get; set; }
		[Ordinal(56)] [RED("personalLinkStatus")] public CEnum<EPersonalLinkConnectionStatus> PersonalLinkStatus { get; set; }
		[Ordinal(57)] [RED("isAdvancedInteractionModeOn")] public CBool IsAdvancedInteractionModeOn { get; set; }
		[Ordinal(58)] [RED("juryrigTrapState")] public CEnum<EJuryrigTrapState> JuryrigTrapState { get; set; }
		[Ordinal(59)] [RED("isControlledByThePlayer")] public CBool IsControlledByThePlayer { get; set; }
		[Ordinal(60)] [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(61)] [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }
		[Ordinal(62)] [RED("wasQuickHackAttempt")] public CBool WasQuickHackAttempt { get; set; }
		[Ordinal(63)] [RED("lastPerformedQuickHack")] public CName LastPerformedQuickHack { get; set; }
		[Ordinal(64)] [RED("isGlitching")] public CBool IsGlitching { get; set; }
		[Ordinal(65)] [RED("isRestarting")] public CBool IsRestarting { get; set; }
		[Ordinal(66)] [RED("blockSecurityWakeUp")] public CBool BlockSecurityWakeUp { get; set; }
		[Ordinal(67)] [RED("isLockedViaSequencer")] public CBool IsLockedViaSequencer { get; set; }
		[Ordinal(68)] [RED("distractExecuted")] public CBool DistractExecuted { get; set; }
		[Ordinal(69)] [RED("distractionTimeCompleted")] public CBool DistractionTimeCompleted { get; set; }
		[Ordinal(70)] [RED("hasNPCWorkspotKillInteraction")] public CBool HasNPCWorkspotKillInteraction { get; set; }
		[Ordinal(71)] [RED("shouldNPCWorkspotFinishLoop")] public CBool ShouldNPCWorkspotFinishLoop { get; set; }
		[Ordinal(72)] [RED("durabilityState")] public CEnum<EDeviceDurabilityState> DurabilityState { get; set; }
		[Ordinal(73)] [RED("hasBeenScavenged")] public CBool HasBeenScavenged { get; set; }
		[Ordinal(74)] [RED("currentlyAuthorizedUsers")] public CArray<SecuritySystemClearanceEntry> CurrentlyAuthorizedUsers { get; set; }
		[Ordinal(75)] [RED("performedActions")] public CArray<SPerformedActions> PerformedActions { get; set; }
		[Ordinal(76)] [RED("isInitialStateOperationPerformed")] public CBool IsInitialStateOperationPerformed { get; set; }
		[Ordinal(77)] [RED("illegalActions")] public IllegalActionTypes IllegalActions { get; set; }
		[Ordinal(78)] [RED("disableQuickHacks")] public CBool DisableQuickHacks { get; set; }
		[Ordinal(79)] [RED("availableQuickHacks")] public CArray<CName> AvailableQuickHacks { get; set; }
		[Ordinal(80)] [RED("isKeyloggerInstalled")] public CBool IsKeyloggerInstalled { get; set; }
		[Ordinal(81)] [RED("actionsWithDisabledRPGChecks")] public CArray<TweakDBID> ActionsWithDisabledRPGChecks { get; set; }
		[Ordinal(82)] [RED("availableSpiderbotActions")] public CArray<CName> AvailableSpiderbotActions { get; set; }
		[Ordinal(83)] [RED("currentSpiderbotActionPerformed")] public CHandle<ScriptableDeviceAction> CurrentSpiderbotActionPerformed { get; set; }
		[Ordinal(84)] [RED("isSpiderbotInteractionOrdered")] public CBool IsSpiderbotInteractionOrdered { get; set; }
		[Ordinal(85)] [RED("shouldScannerShowStatus")] public CBool ShouldScannerShowStatus { get; set; }
		[Ordinal(86)] [RED("shouldScannerShowNetwork")] public CBool ShouldScannerShowNetwork { get; set; }
		[Ordinal(87)] [RED("shouldScannerShowAttitude")] public CBool ShouldScannerShowAttitude { get; set; }
		[Ordinal(88)] [RED("shouldScannerShowRole")] public CBool ShouldScannerShowRole { get; set; }
		[Ordinal(89)] [RED("shouldScannerShowHealth")] public CBool ShouldScannerShowHealth { get; set; }
		[Ordinal(90)] [RED("debugDevice")] public CBool DebugDevice { get; set; }
		[Ordinal(91)] [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(92)] [RED("debugExposeQuickHacks")] public CBool DebugExposeQuickHacks { get; set; }
		[Ordinal(93)] [RED("debugPath")] public CName DebugPath { get; set; }
		[Ordinal(94)] [RED("debugID")] public CUInt32 DebugID { get; set; }
		[Ordinal(95)] [RED("deviceOperationsSetup")] public CHandle<DeviceOperationsContainer> DeviceOperationsSetup { get; set; }
		[Ordinal(96)] [RED("connectionHighlightObjects")] public CArray<NodeRef> ConnectionHighlightObjects { get; set; }
		[Ordinal(97)] [RED("activeContexts")] public CArray<CEnum<gamedeviceRequestType>> ActiveContexts { get; set; }
		[Ordinal(98)] [RED("playstyles")] public CArray<CEnum<EPlaystyle>> Playstyles { get; set; }
		[Ordinal(99)] [RED("quickHackVulnerabilties")] public CArray<TweakDBID> QuickHackVulnerabilties { get; set; }
		[Ordinal(100)] [RED("quickHackVulnerabiltiesInitialized")] public CBool QuickHackVulnerabiltiesInitialized { get; set; }
		[Ordinal(101)] [RED("willingInvestigators")] public CArray<entEntityID> WillingInvestigators { get; set; }
		[Ordinal(102)] [RED("isInteractive")] public CBool IsInteractive { get; set; }

		public ScriptableDeviceComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
