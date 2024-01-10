// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class UE4GitPluginDev : ModuleRules
{
	public UE4GitPluginDev(ReadOnlyTargetRules Target) : base(Target)
	{
		// Do not enforce "Include What You Use" UE4.15 policy
		// since it does not follow the same rules for In-Engine Plugins as for Game Project Plugins,
		// and as such prevents us to make a source code compiling as both.
//		bEnforceIWYU = true;
		IWYUSupport = IWYUSupport.Full;
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
