using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_network : NTerraform.resource
    {
        public class subnet
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

        public azurerm_virtual_network(List<string> @addressSpace,
                                       string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       List<string> @dnsServers = null,
                                       HashSet<subnet> @subnet = null)
        {
            @AddressSpace = @addressSpace;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DnsServers = @dnsServers;
            @Subnet = @subnet;
        }

        public List<string> @AddressSpace { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public List<string> @DnsServers { get; }
        public HashSet<subnet> @Subnet { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
