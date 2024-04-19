using UnrealBuildTool;

public class VR_Attempt_2EditorTarget : TargetRules
{
	public VR_Attempt_2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VR_Attempt_2");
	}
}
