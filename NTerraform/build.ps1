#! /usr/local/bin/pwsh

function Invoke-NTerraformGen
{
    param([string]$type, [string]$name)

    dotnet ../NTerraformGen/bin/Debug/netcoreapp2.1/NTerraformGen.dll cs file $type $name
    if (! $?) { Throw "NTerraform failure: $type $name " }
}


function List-TFSchema
{
    param([string] $type, [string] $def)

    ../tfschema $type list $def
}

terraform init
cat providers.txt | % { Write-Host "Generating provider $_"
                        Invoke-NTerraformGen provider $_ 
                        List-TFSchema data $_ | % { Write-Host "Generating data $_"; Invoke-NTerraformGen data $_ }
                        List-TFSchema resource $_ | % { Write-Host "Generating resource $_"; Invoke-NTerraformGen resource $_ } }
