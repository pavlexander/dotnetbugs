# dotnetbugs
This repository will contain all the bugs that I found in .Net (framework/core)

## Bugs

* 12.03.2019 WrongAssemblyLoaded. Status: **Opened**

In Visual Studio, when trying to reference 1.0.4. version of an assembly - 1.0.1 version of file is being used.. Despite the fact, that project settings are pointing to the correct DLL.
As the result - the solution is still compiled with 1.0.1 version.

https://github.com/dotnet/core/issues/2443

* 13.03.2019 DllIncludesPdbInformation. Status: **Rejected/Closed**

Assembly built with "Portable" debugging information - contains source information.

https://github.com/dotnet/core/issues/2449
https://github.com/dotnet/cli/issues/10982

**UPDATE 25.03.2019**: As it turns out - this is not a bug. Apparently, the PDB file exists not only in BIN folder in the output folder of your project, but also inside OBJ folder. During debug session - Visual Studio tries to lookup this location. When the PDB is found - so is the source. There is more magic involved. I recommend reading through second issue for more information.
