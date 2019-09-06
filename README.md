# framework_reportviewer_repro
reproduction of a build error for coverlet use

created this repo to help MarcoRossignoli from coverlet diagnose an issue

# to recreate the issue...
see discussion of issue here: https://github.com/tonerdo/coverlet/issues/534

using command line, navigate to A.Test and run the following command:

`dotnet test /p:CollectCoverage=true`

Observe the error
```
C:\Program Files\dotnet\sdk\2.2.107\Microsoft.Common.CurrentVersion.targets(2110,5): warning MSB3245: Could not resolve this reference. Could not locate the assembly "Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL". Check to make sure the assembly exists on disk. If this reference is required by your code, you may get compilation errors. [C:\source\framework_reportviewer_repro\C\C.csproj]
Child.cs(8,17): error CS0234: The type or namespace name 'Reporting' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?) [C:\source\framework_reportviewer_repro\C\C.csproj]
Child.cs(12,26): error CS0246: The type or namespace name 'IReportServerConnection' could not be found (are you missing a using directive or an assembly reference?) [C:\source\framework_reportviewer_repro\C\C.csproj]
```
