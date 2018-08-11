# NTerraform
NTerraform aims at writing C# or F# instead of *terraform* syntax. It's a POC as of now but looks really promising.

For example, following terraform definition (from https://www.terraform.io/docs/providers/azurerm/index.html):

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

can be written in C# like this:
```
var provider = new azurerm(environment: "production");
var networkrg = new azurerm_resource_group(name: "production",
                                           location: "West US");

var networkSubnets = new[] { new azurerm_virtual_network.subnet(name: "subnet1", addressPrefix: "10.0.1.0/24"),
                             new azurerm_virtual_network.subnet(name: "subnet2", addressPrefix: "10.0.2.0/24"),
                             new azurerm_virtual_network.subnet(name: "subnet3", addressPrefix: "10.0.3.0/24") };
var network = new azurerm_virtual_network(name: "production-network",
                                          addressSpace: new[] { "10.0.0.0/16" },
                                          location: networkrg.Location,
                                          resourceGroupName: networkrg.Name,
                                          subnet: networkSubnets);

NTerraform.schema.Build();
```

# Dependencies

* TFSchema: use this version https://github.com/pchalamet/tfschema, required for deterministic tf schema support
* Terraform

Both tools must be on PATH.

# Generate new NTerraformLibrary
Script `NTerraform/build.ps1` can regenerate definitions. Update `NTerraform/providers.txt` accordingly.

# Future
This is a POC as stated before. Roadmap is for the moment:

1. Generate tf files
schema.Build() does nothing so it must detect context and generate tf files accordingly.
Idea is to use either FSI (F# interactive) and C# script (https://github.com/filipw/dotnet-script): capture execution contexte and generate tf files.

2. Generate Nugets
NTerraform is just a bunch of code and not modular enough.
Idea is to generate Nugets for each providers and be able to reference each Nuget in script.
For example, C# script support `#r "nuget"` syntax. FSI does not for the moment but is planned.

3. Command line parameters forwarding
NTerraform app should be the entry point and delegate everything to real terraform then in schema.Build().

4. Implement terraform type provider (F#)
Import definition directly from a type provider without requiring prio NTerraform support library reference or compilation.
