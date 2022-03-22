@echo off
setlocal

set ROOTPATH=%~dp0

pushd %ROOTPATH%

set UBT="C:\Program Files\Epic Games\UE_4.27\Engine\Binaries\DotNET\UnrealBuildTool.exe"
if not exist %UBT% (
    echo %UBT% not found
    exit /b
)

for %%a in (*.uproject) do set "UPROJECT=%CD%\%%a"
if not defined UPROJECT (
    echo *.uproject file not found
    exit /b
)

for %%i in ("%UPROJECT%") do (
  set PROJECT=%%~ni
)

echo on
%UBT% %UPROJECT% Win64 Development %PROJECT%Editor

