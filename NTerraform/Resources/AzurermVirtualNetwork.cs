using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_network")]
    public sealed class azurerm_virtual_network : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "subnet")]
        public sealed class subnet
        {
            public subnet(string @addressPrefix,
                          string @name,
                          string @securityGroup = null)
            {
                @AddressPrefix = @addressPrefix;
                @Name = @name;
                @SecurityGroup = @securityGroup;
            }

            [TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "security_group", @out: false, min: 0, max: 1)]
            public string @SecurityGroup { get; }
        }

        public azurerm_virtual_network(string[] @addressSpace,
                                       string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       string[] @dnsServers = null,
                                       subnet[] @subnet = null)
        {
            @AddressSpace = @addressSpace;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DnsServers = @dnsServers;
            @Subnet = @subnet;
        }

        [TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
        public string[] @AddressSpace { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "dns_servers", @out: false, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [TerraformProperty(name: "subnet", @out: false, min: 0, max: 0)]
        public subnet[] @Subnet { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
