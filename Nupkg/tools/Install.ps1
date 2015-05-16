param($installPath, $toolsPath, $package, $project)

function Write-Info($msg) {
    Write-Host "[FluentPro.FluentPS] : " -ForegroundColor DarkRed -NoNewLine; Write-Host "$msg"
}

Write-Info "Installing..."

$libPath = "$installPath\lib\net35\FluentPro.FluentPS.dll"

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
if($fps -ne $null) {
    if($fps.sourcePath -ne $libPath){
        $fps.sourcePath = $libPath 
        $xml.Save($path)
        Write-Info "Package.package updated with new path to lib - $libPath."        
        Write-Info "Done."
        exit 0
    }

    Write-Info "Package.package is up to date with current path to lib - $libPath."        
    Write-Info "Done."

    exit 0
}

$fps = $xml.CreateElement('customAssembly')

$locationAttr = $xml.CreateAttribute("location")
$locationAttr.Value = "FluentPro.FluentPS.dll"
$null = $fps.Attributes.Append($locationAttr)

$deploymentTargetAttr = $xml.CreateAttribute("deploymentTarget")
$deploymentTargetAttr.Value = "GlobalAssemblyCache"
$null = $fps.Attributes.Append($deploymentTargetAttr)

$sourcePathAttr = $xml.CreateAttribute("sourcePath")
$sourcePathAttr.Value = $libPath
$null = $fps.Attributes.Append($sourcePathAttr)

$null = $assemblies.AppendChild($fps)
$xml.Save($path)

Write-Info "Lib added to Package.package."        
Write-Info "Done."

