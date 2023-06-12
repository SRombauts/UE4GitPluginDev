// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE4GitPluginDevEditorTarget : TargetRules
{
	public UE4GitPluginDevEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "UE4GitPluginDev" } );

		// Uncomment to rebuild the whole project without Unity Build, compiling each cpp source file individually, in order to test Includ Whay You Use (IWYU) policy
		// WARNING: don't uncomment on UnrealEngine Source Build, else you will trigger a full new Engine build (but easy to revert, will just relink 1200 lib/dll)
	//	bUseUnityBuild = false;

		DefaultBuildSettings = BuildSettingsVersion.V2;
	}
}
