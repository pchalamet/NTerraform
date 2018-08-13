# NTerraform
NTerraform aims at writing F# instead of *terraform* syntax. It's a POC as of now but looks really promising.

Pros:
* F# syntax is easier to grasp and offers new world of opportunities
* fully typed and completion ready !

Cons:
* it's merely a new layer on top of terraform
* terraform plugins often do not implement correctly schema interface

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
#r "nterraform.dll"

open nterraform
open nterraform.providers
open nterraform.resources

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

This script can then be executed through FSI, for example:
```
fsi src\sandboxFS\Sample.fsx
```

it will write on console (but will in the future be pipelined to terraform):
```
provider "azurerm" "provider" {
  environment = "dev"
}

resource "azurerm_resource_group" "resgroup" {
  location = "West US"
  name = "production"
}

resource "azurerm_virtual_network" "network" {
  address_space = [ "10.0.0.0/16" ]
  location = "West US"
  name = "production-network"
  resource_group_name = "production"
  subnet = {
    address_prefix = "10.0.1.0/24"
    name = "subnet1"
  }
  subnet = {
    address_prefix = "10.0.2.0/24"
    name = "subnet2"
  }
  subnet = {
    address_prefix = "10.0.3.0/24"
    name = "subnet3"
  }
}
```

Following plugins are included:
* azurerm
* aws
* consul

# Dependencies
* TFSchema: use this version https://github.com/pchalamet/tfschema, required for deterministic tf schema support
* Terraform

Both tools must be on PATH.

# Generate new NTerraformLibrary
Script `src/nterraform/build.ps1` can regenerate definitions. Update `src/nterraform/plugins.txt` accordingly.
Note that if a terraform plugin does not work well (for eg aws), rebuild it from go sources and it should work.

# Future
This is a POC as stated before. Following items are in sight:

## Generate Nugets
NTerraform is just a bunch of code and not modular enough.
Idea is to generate Nugets for each providers and be able to reference each Nuget in script.
For example, C# script support `#r "nuget"` syntax. FSI does not for the moment but is planned.

## Forward command line parameters
NTerraform script should be the entry point and delegate everything to real terraform then in configuration.build().
Also should be able to support outputs by parsing terraform output.

## Switch to F# data model
Type model is implemented in C# for the moment. F# does not support nested class nor easy module definition.
There is already an F# generator but it miss module support so conflicts can arise.
F# types would be far better
* immutable collections & native F# collection (list, Map & Set)
This is a low priority as C# host is still considered (using dotnet-script).
Branch `feature/fsharptypes` does support FSharp's list, set, map and option. But this bring too little values to go forward with that for the moment.