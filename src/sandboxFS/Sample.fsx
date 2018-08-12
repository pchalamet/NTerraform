
#r "../nterraform/bin/Debug/netcoreapp2.0/nterraform.dll"

open nterraform
open nterraform.providers
open nterraform.resources

let provider = azurerm(environment = "dev")

let resgroup = azurerm_resource_group(name = "production",
                                      location = "West US")

let subnets = [ azurerm_virtual_network.subnet(name = "subnet1", addressPrefix = "10.0.1.0/24")
                azurerm_virtual_network.subnet(name = "subnet2", addressPrefix = "10.0.2.0/24")
                azurerm_virtual_network.subnet(name = "subnet3", addressPrefix = "10.0.3.0/24") ]

let network = azurerm_virtual_network(name = "production-network",
                                      addressSpace = [ "10.0.0.0/16" ],
                                      location = resgroup.Location,
                                      resourceGroupName = resgroup.Name,
                                      subnet = subnets)

configuration.build()
