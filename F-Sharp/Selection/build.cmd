@echo off
if not exist tools\FAKE\tools\Fake.exe (
  .nuget\nuget.exe "install" "FAKE" "-OutputDirectory" "tools" "-ExcludeVersion"
)
tools\FAKE\tools\FAKE.exe build.fsx %*
pause
