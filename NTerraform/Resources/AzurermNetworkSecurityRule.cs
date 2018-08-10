using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_network_security_rule : NTerraform.resource
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
                                             HashSet<string> @destinationAddressPrefixes = null,
                                             HashSet<string> @destinationApplicationSecurityGroupIds = null,
                                             string @destinationPortRange = null,
                                             HashSet<string> @destinationPortRanges = null,
                                             string @sourceAddressPrefix = null,
                                             HashSet<string> @sourceAddressPrefixes = null,
                                             HashSet<string> @sourceApplicationSecurityGroupIds = null,
                                             string @sourcePortRange = null,
                                             HashSet<string> @sourcePortRanges = null)
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
        public HashSet<string> @DestinationAddressPrefixes { get; }
        public HashSet<string> @DestinationApplicationSecurityGroupIds { get; }
        public string @DestinationPortRange { get; }
        public HashSet<string> @DestinationPortRanges { get; }
        public string @SourceAddressPrefix { get; }
        public HashSet<string> @SourceAddressPrefixes { get; }
        public HashSet<string> @SourceApplicationSecurityGroupIds { get; }
        public string @SourcePortRange { get; }
        public HashSet<string> @SourcePortRanges { get; }
    }

}
