using UnrealBuildTool;

public class VR_Attempt_2ServerTarget : TargetRules
{
	public VR_Attempt_2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VR_Attempt_2");
	}
}
