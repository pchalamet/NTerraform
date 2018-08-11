using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_network_security_rule : NTerraform.resource
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
        }

        public string @Access { get; }
        public string @Direction { get; }
        public string @Name { get; }
        public string @NetworkSecurityGroupName { get; }
        public int @Priority { get; }
        public string @Protocol { get; }
        public string @ResourceGroupName { get; }
        public string @Description { get; }
        public string @DestinationAddressPrefix { get; }
        public string[] @DestinationAddressPrefixes { get; }
        public string[] @DestinationApplicationSecurityGroupIds { get; }
        public string @DestinationPortRange { get; }
        public string[] @DestinationPortRanges { get; }
        public string @SourceAddressPrefix { get; }
        public string[] @SourceAddressPrefixes { get; }
        public string[] @SourceApplicationSecurityGroupIds { get; }
        public string @SourcePortRange { get; }
        public string[] @SourcePortRanges { get; }
    }

}
