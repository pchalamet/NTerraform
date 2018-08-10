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

        public azurerm_network_security_group(string @location,
                                              string @name,
                                              string @resourceGroupName,
                                              HashSet<security_rule> @securityRule = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @SecurityRule = @securityRule;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public HashSet<security_rule> @SecurityRule { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
