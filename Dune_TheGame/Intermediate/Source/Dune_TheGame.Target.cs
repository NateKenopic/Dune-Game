using UnrealBuildTool;

public class Dune_TheGameTarget : TargetRules
{
	public Dune_TheGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Dune_TheGame");
	}
}
