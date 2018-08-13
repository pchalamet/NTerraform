#! "netcoreapp2.1"

#r "../nterraform/bin/Debug/netcoreapp2.0/nterraform.dll"

using nterraform;
using nterraform.providers;
using nterraform.resources;

Console.WriteLine("Creating schema...");
var provider = new azurerm(environment: "dev");
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

Console.WriteLine("Building schema...");
configuration.build();
Console.WriteLine("Done");
