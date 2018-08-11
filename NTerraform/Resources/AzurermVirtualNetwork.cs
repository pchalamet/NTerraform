using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_virtual_network : NTerraform.resource
    {
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

            public string @AddressPrefix { get; }
            public string @Name { get; }
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

        public string[] @AddressSpace { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string[] @DnsServers { get; }
        public subnet[] @Subnet { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
