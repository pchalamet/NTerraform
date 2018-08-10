module AzurermVirtualNetwork

type Subnet(addressPrefix : string,
            name : string,
            ?securityGroup : string) =
    member this.AddressPrefix = addressPrefix
    member this.Name = name
    member this.SecurityGroup = securityGroup
    
type AzurermVirtualNetwork(addressSpace: string list, 
                           location : string, 
                           name : string, 
                           resourceGroupName : string,
                           ?dnsServers : string list,
                           ?tags : Map<string, string>,
                           ?subnets : Subnet list) =
    inherit NTerraformCore.Resource()

    member this.AddressSpace = addressSpace
    member this.Location = location
    member this.Name = name
    member this.ResourceGroupName = resourceGroupName
    member this.DnsServers = dnsServers
    member this.Tags = tags
    member this.Subnets = subnets
