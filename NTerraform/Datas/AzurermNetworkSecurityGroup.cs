using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_network_security_group : NTerraform.data
    {
        public class security_rule
        {
            public security_rule(string[] @destinationApplicationSecurityGroupIds = null,
                                 string[] @sourceApplicationSecurityGroupIds = null)
            {
                @DestinationApplicationSecurityGroupIds = @destinationApplicationSecurityGroupIds;
                @SourceApplicationSecurityGroupIds = @sourceApplicationSecurityGroupIds;
            }

            public string @Access { get; }
            public string @Description { get; }
            public string @DestinationAddressPrefix { get; }
            public string[] @DestinationAddressPrefixes { get; }
            public string[] @DestinationApplicationSecurityGroupIds { get; }
            public string @DestinationPortRange { get; }
            public string[] @DestinationPortRanges { get; }
            public string @Direction { get; }
            public string @Name { get; }
            public int? @Priority { get; }
            public string @Protocol { get; }
            public string @SourceAddressPrefix { get; }
            public string[] @SourceAddressPrefixes { get; }
            public string[] @SourceApplicationSecurityGroupIds { get; }
            public string @SourcePortRange { get; }
            public string[] @SourcePortRanges { get; }
        }

        public azurerm_network_security_group(string @name,
                                              string @resourceGroupName,
                                              security_rule[] @securityRule = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @SecurityRule = @securityRule;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public security_rule[] @SecurityRule { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
