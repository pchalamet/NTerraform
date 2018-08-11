
#r "../NTerraform/bin/Debug/netcoreapp2.0/NTerraform.dll"

open NTerraform.Providers
open NTerraform.Resources

let provider = azurerm(environment = "dev")
let networkrg = azurerm_resource_group(name = "production",
                                       location = "West US")

let networkSubnets = [| azurerm_virtual_network.subnet(name = "subnet1", addressPrefix = "10.0.1.0/24")
                        azurerm_virtual_network.subnet(name = "subnet2", addressPrefix = "10.0.2.0/24")
                        azurerm_virtual_network.subnet(name = "subnet3", addressPrefix = "10.0.3.0/24") |]
let network = azurerm_virtual_network(name = "production-network",
                                      addressSpace = [| "10.0.0.0/16" |],
                                      location = networkrg.Location,
                                      resourceGroupName = networkrg.Name,
                                      subnet = networkSubnets)

NTerraform.schema.Build()
