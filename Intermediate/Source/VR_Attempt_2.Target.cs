using UnrealBuildTool;

public class VR_Attempt_2Target : TargetRules
{
	public VR_Attempt_2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_Attempt_2");
	}
}
