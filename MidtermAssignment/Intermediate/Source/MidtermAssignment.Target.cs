using UnrealBuildTool;

public class MidtermAssignmentTarget : TargetRules
{
	public MidtermAssignmentTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MidtermAssignment");
	}
}
