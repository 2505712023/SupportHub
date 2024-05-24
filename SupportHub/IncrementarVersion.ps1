# Ruta al archivo del proyecto
$projectFile = ".\SupportHub\Presentacion.csproj"

# Lee el archivo del proyecto
$xml = [xml](Get-Content $projectFile)

# Obtiene la versión actual del proyecto
$currentVersion = $xml.Project.PropertyGroup.Version

# Incrementa el número de versión (agrega 1 al último segmento)
$newVersion = [version]$currentVersion
$newVersion = $newVersion.Major, $newVersion.Minor, $newVersion.Build, ($newVersion.Revision + 1) -join '.'

# Actualiza la versión en el archivo del proyecto
$xml.Project.PropertyGroup.Version = $newVersion
$xml.Save($projectFile)

# Devuelve la nueva versión
$newVersion
