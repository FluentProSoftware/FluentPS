properties {
    $root = Resolve-Path "$($psake.build_script_dir)\.."    
    $nuget = "$($root)\Source\FluentPro.FluentPS\.nuget\NuGet.exe"
    $ilrepack = "$($root)\FluentPro.FluentPS\packages\ILRepack.1.26.0\tools\ILRepack.exe"
    $conf = "Release"
    $packagesFolder = "$($root)\Packages"

    $prjFolder = "$($root)\Source\FluentPro.FluentPS\FluentPro.FluentPS"
    $nupkgsInPrjFolder = "$($prjFolder)\*.nupkg"
    $prj = "$($prjFolder)\FluentPro.FluentPS.csproj"

    $sln = "$($root)\Source\FluentPro.FluentPS\FluentPro.FluentPS.sln"
}

task Clean { 
    msbuild $sln /t:Clean /p:Configuration=$conf
    Get-ChildItem $prjFolder -Include *.nupkg -Recurse | % { Remove-Item $_.FullName }
    Remove-Item $packagesFolder -Force -Recurse -ErrorAction SilentlyContinue 
}

task RestorePackages -Depends Clean {  
    &$nuget restore $sln
}

task Build -Depends RestorePackages {
    msbuild $prj /t:Build /p:Configuration=$conf

    New-Item -ItemType directory -Path $packagesFolder
    &$nuget pack $prj -Symbols -OutputDirectory $packagesFolder -Prop Configuration=$conf
}

task Publish -Depends Build{
    Get-ChildItem $packagesFolder -Include *.nupkg -Exclude *.symbols.nupkg -Recurse | % { &$nuget push $_.FullName }
}