using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_network_security_group")]
    public sealed class azurerm_network_security_group : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "security_rule")]
        public sealed class security_rule
        {
            public security_rule(string @access,
                                 string @direction,
                                 string @name,
                                 int @priority,
                                 string @protocol,
                                 string @description = null,
                                 string @destinationAddressPrefix = null,
                                 string[] @destinationAddressPrefixes = null,
                                 string[] @destinationApplicationSecurityGroupIds = null,
                                 string @destinationPortRange = null,
                                 string[] @destinationPortRanges = null,
                                 string @sourceAddressPrefix = null,
                                 string[] @sourceAddressPrefixes = null,
                                 string[] @sourceApplicationSecurityGroupIds = null,
                                 string @sourcePortRange = null,
                                 string[] @sourcePortRanges = null)
            {
                @Access = @access;
                @Direction = @direction;
                @Name = @name;
                @Priority = @priority;
                @Protocol = @protocol;
                @Description = @description;
                @DestinationAddressPrefix = @destinationAddressPrefix;
                @DestinationAddressPrefixes = @destinationAddressPrefixes;
                @DestinationApplicationSecurityGroupIds = @destinationApplicationSecurityGroupIds;
                @DestinationPortRange = @destinationPortRange;
                @DestinationPortRanges = @destinationPortRanges;
                @SourceAddressPrefix = @sourceAddressPrefix;
                @SourceAddressPrefixes = @sourceAddressPrefixes;
                @SourceApplicationSecurityGroupIds = @sourceApplicationSecurityGroupIds;
                @SourcePortRange = @sourcePortRange;
                @SourcePortRanges = @sourcePortRanges;
            }

            [TerraformProperty(name: "access", @out: false, nested: false, min: 1, max: 1)]
            public string @Access { get; }

            [TerraformProperty(name: "direction", @out: false, nested: false, min: 1, max: 1)]
            public string @Direction { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "priority", @out: false, nested: false, min: 1, max: 1)]
            public int @Priority { get; }

            [TerraformProperty(name: "protocol", @out: false, nested: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [TerraformProperty(name: "description", @out: false, nested: false, min: 0, max: 1)]
            public string @Description { get; }

            [TerraformProperty(name: "destination_address_prefix", @out: false, nested: false, min: 0, max: 1)]
            public string @DestinationAddressPrefix { get; }

            [TerraformProperty(name: "destination_address_prefixes", @out: false, nested: false, min: 0, max: 1)]
            public string[] @DestinationAddressPrefixes { get; }

            [TerraformProperty(name: "destination_application_security_group_ids", @out: false, nested: false, min: 0, max: 1)]
            public string[] @DestinationApplicationSecurityGroupIds { get; }

            [TerraformProperty(name: "destination_port_range", @out: false, nested: false, min: 0, max: 1)]
            public string @DestinationPortRange { get; }

            [TerraformProperty(name: "destination_port_ranges", @out: false, nested: false, min: 0, max: 1)]
            public string[] @DestinationPortRanges { get; }

            [TerraformProperty(name: "source_address_prefix", @out: false, nested: false, min: 0, max: 1)]
            public string @SourceAddressPrefix { get; }

            [TerraformProperty(name: "source_address_prefixes", @out: false, nested: false, min: 0, max: 1)]
            public string[] @SourceAddressPrefixes { get; }

            [TerraformProperty(name: "source_application_security_group_ids", @out: false, nested: false, min: 0, max: 1)]
            public string[] @SourceApplicationSecurityGroupIds { get; }

            [TerraformProperty(name: "source_port_range", @out: false, nested: false, min: 0, max: 1)]
            public string @SourcePortRange { get; }

            [TerraformProperty(name: "source_port_ranges", @out: false, nested: false, min: 0, max: 1)]
            public string[] @SourcePortRanges { get; }
        }

        public azurerm_network_security_group(string @location,
                                              string @name,
                                              string @resourceGroupName,
                                              security_rule[] @securityRule = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @SecurityRule = @securityRule;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "security_rule", @out: false, nested: true, min: 0, max: 0)]
        public security_rule[] @SecurityRule { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
