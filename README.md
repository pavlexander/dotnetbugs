# dotnetbugs
This repository will contain all the bugs that I found in .Net (framework/core)

## Bugs

* 12.03.2019 WrongAssemblyLoaded

In Visual Studio, when trying to reference 1.0.4. version of an assembly - 1.0.1 version of file is being used.. Despite the fact, that project settings are pointing to the correct DLL.
As the result - the solution is still compiled with 1.0.1 version.

https://github.com/dotnet/core/issues/2443
