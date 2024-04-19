using UnrealBuildTool;

public class VR_Attempt_2ClientTarget : TargetRules
{
	public VR_Attempt_2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VR_Attempt_2");
	}
}
