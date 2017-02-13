@echo off

set SolutionDir=%~dp0
set SolutionName=Newtonsoft.Json.Dotnet
set Project=Newtonsoft.Json

REM Cleanup output directory
rmdir /s/q "%SolutionDir%Output" 2> nul
mkdir "%SolutionDir%Output"

CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net45 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net40 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net35-client || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net35-cf || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% net20 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% profile259 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% profile328 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% netstandard1.0 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% netstandard1.1 || EXIT /B 1
CALL %SolutionDir%tools\build-dotnet.bat %SolutionDir% %Project% netstandard1.3 || EXIT /B 1

echo build complete.
EXIT /B %ERRORLEVEL%
