using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network")]
    public sealed class azurerm_virtual_network : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "subnet")]
        public sealed class subnet : nterraform.Core.structure
        {
            public subnet(string @addressPrefix,
                          string @name,
                          string @securityGroup = null)
            {
                @AddressPrefix = @addressPrefix;
                @Name = @name;
                @SecurityGroup = @securityGroup;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "security_group", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
        public string[] @AddressSpace { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "dns_servers", @out: false, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [nterraform.Core.TerraformProperty(name: "subnet", @out: false, min: 0, max: 0)]
        public subnet[] @Subnet { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
