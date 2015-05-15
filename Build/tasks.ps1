properties {
    $root = Resolve-Path "$($psake.build_script_dir)\.."    
    $nuget = "$($root)\Source\FluentPro.FluentPS\.nuget\NuGet.exe"
    $conf = "Release"
    $artifacts = "$($root)\Artifacts"

    $nupkgRoot = "$($root)\Nupkg"
    $nupkgLib = "$($nupkgRoot)\Lib\net35"
    $nuspec = "$($nupkgRoot)\FluentPro.FluentPS.nuspec"

    $prjFolder = "$($root)\Source\FluentPro.FluentPS\FluentPro.FluentPS"
    $prjOutput = "$($prjFolder)\bin\$($conf)"
    $prj = "$($prjFolder)\FluentPro.FluentPS.csproj"

    $sln = "$($root)\Source\FluentPro.FluentPS\FluentPro.FluentPS.sln"
}

task Clean { 
    msbuild $sln /t:Clean /p:Configuration=$conf
    Get-ChildItem $prjFolder -Include *.nupkg -Recurse | % { Remove-Item $_.FullName }    
    Get-ChildItem $artifacts -Include * -Recurse | % { Remove-Item $_.FullName }
    Get-ChildItem $nupkgLib -Include * -Recurse | % { Remove-Item $_.FullName }
}

task RestorePackages -Depends Clean {  
    &$nuget restore $sln
}

task Build -Depends RestorePackages {
    msbuild $prj /t:Build /p:Configuration=$conf
    Get-ChildItem $prjOutput -Include *.dll, *.pdb -Recurse | % { Copy-Item $_.FullName -Destination $nupkgLib}

    $assembly = [Reflection.Assembly]::ReflectionOnlyLoadFrom("$nupkgLib\FluentPro.FluentPS.dll")
    $id = Get-AttributeValue $assembly "System.Reflection.AssemblyTitleAttribute"
    $title = Get-AttributeValue $assembly "System.Reflection.AssemblyTitleAttribute"
    $version = Get-AttributeValue $assembly "System.Reflection.AssemblyInformationalVersionAttribute"
    $author = Get-AttributeValue $assembly "System.Reflection.AssemblyCompanyAttribute"
    $description = Get-AttributeValue $assembly "System.Reflection.AssemblyDescriptionAttribute"

    &$nuget pack $nuspec `
        -Symbols `
        -OutputDirectory $artifacts `
        -Prop Id=$id `
        -Prop Title=$title `
        -Prop Version=$version `
        -Prop Author=$author `
        -Prop Description=$description `
        -Prop Configuration=$conf
}

task Publish -Depends Build{
    Get-ChildItem $artifacts -Include *.nupkg -Exclude *.symbols.nupkg -Recurse | % { &$nuget push $_.FullName }
}

function Get-AttributeValue($assembly, $attrName) 
{
    $val = [Reflection.CustomAttributeData]::GetCustomAttributes($assembly) `
       | ? { $_.AttributeType -like $attrName } `
       | select -ExpandProperty ConstructorArguments `
       | select -First 1 

    return $val[0].Value
}