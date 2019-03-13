# dotnetbugs
This repository will contain all the bugs that I found in .Net (framework/core)

## Bugs

* 12.03.2019 WrongAssemblyLoaded
Few issue issues:
1. In Visual Studio, when trying to reference 1.0.4. version of an assembly - 1.0.1 version of file is being used.. Despite the fact, that project settings are pointing to the correct DLL.
As the result - the solution is still compiled with 1.0.1 version.
2. Second issue, is that "dotnet build" command when executed on ".csproj" file - does not put the referenced DLL into an output directory, hovewer, when the command is executed on solution level, then all files are copied correctly.
