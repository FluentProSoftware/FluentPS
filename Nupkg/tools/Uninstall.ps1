param($installPath, $toolsPath, $package, $project)

function Write-Info($msg) {
    Write-Host "[FluentPro.FluentPS] : " -ForegroundColor DarkRed -NoNewLine; Write-Host "$msg"
}

Write-Info "Installing..."

Write-Info "Try to update Package.package... "
$pkg = $project.ProjectItems.Item("Package").ProjectItems.Item("Package.package")
if($pkg -eq $null){
    Write-Info "Package.package not found in project. Looks like it is not SharePoint WSP project."      
    Write-Info "Done."
    exit 0
}

$xml = [xml](Get-Content $pkg.Document.FullName)
$assemblies = $xml.package.assemblies
$fps = $assemblies.customAssembly | ? { $_.location -eq "FluentPro.FluentPS.dll" } | select -First 1
if($fps -eq $null){   
    Write-Info "Lib was not found in Package.package." 
    Write-Info "Done."
    exit 0
}

$null = $assemblies.RemoveChild($fps)
$xml.Save($path)    

Write-Info "Lib removed from Package.package." 
Write-Info "Done."