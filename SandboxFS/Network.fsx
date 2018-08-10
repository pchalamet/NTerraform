
#r "bin/Debug/netcoreapp2.1/NTerraformSandbox.dll"

open AzurermVirtualNetwork

//let rnd = RandomInteger(min=1, max = 99)

//let mainResGrp = AzurermResourceGroup(name = "main", 
//                                      location = sprintf "westus %s" rnd.id)

//let mainSecGroup = AzurermNetworkSecurityGroup(name = "main", 
                                               //location = mainResGrp.Location, 
                                               //resourceGroupName = mainResGrp.Name)


let mainVN = AzurermVirtualNetwork(name = "main",
                                   resourceGroupName = "main",
                                   addressSpace = ["10.0.0.0/1"],
                                   location = "westus",
                                   dnsServers = ["10.0.0.4"; "10.0.0.5"])

