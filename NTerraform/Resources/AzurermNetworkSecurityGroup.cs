using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_network_security_group : NTerraform.resource
    {
        public class security_rule
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

            public string @Access { get; }
            public string @Direction { get; }
            public string @Name { get; }
            public int @Priority { get; }
            public string @Protocol { get; }
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

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public security_rule[] @SecurityRule { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
