#! /usr/local/bin/pwsh

function Invoke-NTerraformGen
{
    param([string]$plugin, [string]$category, [string]$typeName)

    dotnet ../nterraformGen/bin/Debug/netcoreapp2.1/nterraformGen.dll cs file $plugin $category $typeName
    if (! $?) { Throw "NTerraform failure: $plugin $category $typeName" }
}


function List-TFSchema
{
    param([string] $type, [string] $def)

    ../../tools/tfschema $type list $def
}

terraform init
cat providers.txt | % { $plugin = $_
                        Write-Host "Generating provider $plugin"
                        Invoke-NTerraformGen $plugin provider $plugin 
                        List-TFSchema data $plugin | % { Write-Host "Generating data $_"; Invoke-NTerraformGen $plugin data $_ }
                        List-TFSchema resource $plugin | % { Write-Host "Generating resource $_"; Invoke-NTerraformGen $plugin resource $_ } }
