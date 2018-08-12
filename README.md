# NTerraform
NTerraform aims at writing F# instead of *terraform* syntax. It's a POC as of now but looks really promising.

Pros:
* F# syntax is easier to grasp and offers new world of opportunities
* fully typed and completion ready !

Cons:
* it's merely a new layer on top of terraform

# Example
Here is a terraform definition (from https://www.terraform.io/docs/providers/azurerm/index.html):

```
# Configure the Azure Provider
provider "azurerm" { 
  environment = "production"
}

# Create a resource group
resource "azurerm_resource_group" "network" {
  name     = "production"
  location = "West US"
}

# Create a virtual network within the resource group
resource "azurerm_virtual_network" "network" {
  name                = "production-network"
  address_space       = ["10.0.0.0/16"]
  location            = "${azurerm_resource_group.network.location}"
  resource_group_name = "${azurerm_resource_group.network.name}"

  subnet {
    name           = "subnet1"
    address_prefix = "10.0.1.0/24"
  }

  subnet {
    name           = "subnet2"
    address_prefix = "10.0.2.0/24"
  }

  subnet {
    name           = "subnet3"
    address_prefix = "10.0.3.0/24"
  }
}
```

Which can be rewritten as an F# script:
```fsharp
open nterraform
open nterraform.providers
open nterraform.resources.azurerm

let provider = azurerm(environment = "dev")

let resgroup = azurerm_resource_group(name = "production",
                                      location = "West US")

let subnets = [| azurerm_virtual_network.subnet(name = "subnet1", addressPrefix = "10.0.1.0/24")
                 azurerm_virtual_network.subnet(name = "subnet2", addressPrefix = "10.0.2.0/24")
                 azurerm_virtual_network.subnet(name = "subnet3", addressPrefix = "10.0.3.0/24") |]

let network = azurerm_virtual_network(name = "production-network",
                                      addressSpace = [| "10.0.0.0/16" |],
                                      location = resgroup.Location,
                                      resourceGroupName = resgroup.Name,
                                      subnet = subnets)

configuration.build()
```

This script can then be executed through FSI (it will write to stdout the terraform definition).

# Dependencies
* TFSchema: use this version https://github.com/pchalamet/tfschema, required for deterministic tf schema support
* Terraform

Both tools must be on PATH.

# Generate new NTerraformLibrary
Script `NTerraform/build.ps1` can regenerate definitions. Update `NTerraform/providers.txt` accordingly.

# Future
This is a POC as stated before. Roadmap is for the moment:

1. Generate tf files (DONE): 
schema.Build() does nothing so it must detect context and generate tf files accordingly.
Idea is to use either FSI (F# interactive) and C# script (https://github.com/filipw/dotnet-script): capture execution contexte and generate tf files.

2. Generate Nugets: 
NTerraform is just a bunch of code and not modular enough.
Idea is to generate Nugets for each providers and be able to reference each Nuget in script.
For example, C# script support `#r "nuget"` syntax. FSI does not for the moment but is planned.

3. Command line parameters forwarding: 
NTerraform app should be the entry point and delegate everything to real terraform then in schema.Build().
Also should be able to support outputs by parsing terraform output.

4. Implement terraform type provider (F#): 
Import definition directly from a type provider without requiring prior NTerraform support library reference or compilation. Could be slow.

5. Switch to a fully F# type model. F# has a showstopper as of now: no support for nested class. Optional support is weak unfortunately.