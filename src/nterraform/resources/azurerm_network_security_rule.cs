using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_network_security_rule")]
    public sealed class azurerm_network_security_rule : nterraform.Core.resource
    {
        public azurerm_network_security_rule(string @access,
                                             string @direction,
                                             string @name,
                                             string @networkSecurityGroupName,
                                             int @priority,
                                             string @protocol,
                                             string @resourceGroupName,
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
            @NetworkSecurityGroupName = @networkSecurityGroupName;
            @Priority = @priority;
            @Protocol = @protocol;
            @ResourceGroupName = @resourceGroupName;
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

        [nterraform.Core.TerraformProperty(name: "access", @out: false, min: 1, max: 1)]
        public string @Access { get; }

        [nterraform.Core.TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
        public string @Direction { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "network_security_group_name", @out: false, min: 1, max: 1)]
        public string @NetworkSecurityGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
        public int @Priority { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "destination_address_prefix", @out: false, min: 0, max: 1)]
        public string @DestinationAddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "destination_address_prefixes", @out: false, min: 0, max: 1)]
        public string[] @DestinationAddressPrefixes { get; }

        [nterraform.Core.TerraformProperty(name: "destination_application_security_group_ids", @out: false, min: 0, max: 1)]
        public string[] @DestinationApplicationSecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "destination_port_range", @out: false, min: 0, max: 1)]
        public string @DestinationPortRange { get; }

        [nterraform.Core.TerraformProperty(name: "destination_port_ranges", @out: false, min: 0, max: 1)]
        public string[] @DestinationPortRanges { get; }

        [nterraform.Core.TerraformProperty(name: "source_address_prefix", @out: false, min: 0, max: 1)]
        public string @SourceAddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "source_address_prefixes", @out: false, min: 0, max: 1)]
        public string[] @SourceAddressPrefixes { get; }

        [nterraform.Core.TerraformProperty(name: "source_application_security_group_ids", @out: false, min: 0, max: 1)]
        public string[] @SourceApplicationSecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "source_port_range", @out: false, min: 0, max: 1)]
        public string @SourcePortRange { get; }

        [nterraform.Core.TerraformProperty(name: "source_port_ranges", @out: false, min: 0, max: 1)]
        public string[] @SourcePortRanges { get; }
    }

}
