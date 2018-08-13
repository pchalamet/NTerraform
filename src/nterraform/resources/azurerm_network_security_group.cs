using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_network_security_group")]
    public sealed class azurerm_network_security_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "security_rule")]
        public sealed class security_rule : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "access", @out: false, min: 1, max: 1)]
            public string @Access { get; }

            [nterraform.TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
            public string @Direction { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.TerraformProperty(name: "destination_address_prefix", @out: false, min: 0, max: 1)]
            public string @DestinationAddressPrefix { get; }

            [nterraform.TerraformProperty(name: "destination_address_prefixes", @out: false, min: 0, max: 1)]
            public string[] @DestinationAddressPrefixes { get; }

            [nterraform.TerraformProperty(name: "destination_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @DestinationApplicationSecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "destination_port_range", @out: false, min: 0, max: 1)]
            public string @DestinationPortRange { get; }

            [nterraform.TerraformProperty(name: "destination_port_ranges", @out: false, min: 0, max: 1)]
            public string[] @DestinationPortRanges { get; }

            [nterraform.TerraformProperty(name: "source_address_prefix", @out: false, min: 0, max: 1)]
            public string @SourceAddressPrefix { get; }

            [nterraform.TerraformProperty(name: "source_address_prefixes", @out: false, min: 0, max: 1)]
            public string[] @SourceAddressPrefixes { get; }

            [nterraform.TerraformProperty(name: "source_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SourceApplicationSecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "source_port_range", @out: false, min: 0, max: 1)]
            public string @SourcePortRange { get; }

            [nterraform.TerraformProperty(name: "source_port_ranges", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "security_rule", @out: false, min: 0, max: 0)]
        public security_rule[] @SecurityRule { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
