@echo off
setlocal

set ROOTPATH=%~dp0

pushd %ROOTPATH%

set UEPATH=C:\Program Files\Epic Games\UE_4.27\
set UBT="%UEPATH%Engine\Binaries\DotNET\UnrealBuildTool.exe"
set PROJECT=UE4GitPluginDev
set UPROJECT="%ROOTPATH%\%PROJECT%.uproject"

echo on
%UBT% %UPROJECT% Win64 Development %PROJECT%Editor

