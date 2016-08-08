@IF "%1" == "" (
    @SET CONFIGURATION=Release
) ELSE (
    @SET CONFIGURATION=%1
)

del /s /q /f "src\Aq.Interop.ErrorCodes\bin\%CONFIGURATION%\*.nupkg"
dotnet pack -c "%CONFIGURATION%" "src\Aq.Interop.ErrorCodes\project.json"
xcopy "src\Aq.Interop.ErrorCodes\bin\%CONFIGURATION%\*.nupkg" "%NUGET_LOCAL%" /f /i /y
