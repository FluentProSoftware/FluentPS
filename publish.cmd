cd Source\FluentPro.FluentPS
..\.nuget\NuGet.exe restore

cd FluentPro.FluentPS
del /S *.nupkg
msbuild /p:Configuration=Release
..\.nuget\NuGet.exe pack -Symbols -Prop Configuration=Release
cd ..\..\..

RD /S /Q Packages
md Packages
xcopy Source\FluentPro.FluentPS\FluentPro.FluentPS\FluentPro.FluentPS.*.nupkg Packages
Source\FluentPro.FluentPS\.nuget\NuGet.exe push Packages\FluentPro.FluentPS.*.nupkg