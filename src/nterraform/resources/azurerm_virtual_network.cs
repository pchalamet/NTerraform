using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network")]
    public sealed class azurerm_virtual_network : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "subnet")]
        public sealed class subnet : nterraform.structure
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

            [nterraform.TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
            public string @AddressPrefix { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "security_group", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
        public string[] @AddressSpace { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "dns_servers", @out: false, min: 0, max: 1)]
        public string[] @DnsServers { get; }

        [nterraform.TerraformProperty(name: "subnet", @out: false, min: 0, max: 0)]
        public subnet[] @Subnet { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
