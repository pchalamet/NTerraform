#! /usr/local/bin/pwsh

function Invoke-NTerraformGen
{
    param([string]$type, [string]$name)

    dotnet ../NTerraformGen/bin/Debug/netcoreapp2.1/NTerraformGen.dll cs file $type $name
    if (! $?) { Throw "NTerraform failure: $type $name " }
}


function Invoke-TFSchema
{
    param([string] $provider)

    ../tfschema resource list $provider
}

terraform init
Invoke-TFSchema azurerm | % { Write-Host "Generating resource $_"; Invoke-NTerraformGen resource $_ }
Invoke-TFSchema consul | % { Write-Host "Generating resource $_"; Invoke-NTerraformGen resource $_ }

