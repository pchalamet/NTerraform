using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_network_security_group")]
    public sealed class azurerm_network_security_group : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "security_rule")]
        public sealed class security_rule : nterraform.Core.structure
        {
            public security_rule(string[] @destinationApplicationSecurityGroupIds = null,
                                 string[] @sourceApplicationSecurityGroupIds = null)
            {
                @DestinationApplicationSecurityGroupIds = @destinationApplicationSecurityGroupIds;
                @SourceApplicationSecurityGroupIds = @sourceApplicationSecurityGroupIds;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "access", @out: true, min: 0, max: 1)]
            public string @Access { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "destination_address_prefix", @out: true, min: 0, max: 1)]
            public string @DestinationAddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "destination_address_prefixes", @out: true, min: 0, max: 1)]
            public string[] @DestinationAddressPrefixes { get; }

            [nterraform.Core.TerraformProperty(name: "destination_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @DestinationApplicationSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "destination_port_range", @out: true, min: 0, max: 1)]
            public string @DestinationPortRange { get; }

            [nterraform.Core.TerraformProperty(name: "destination_port_ranges", @out: true, min: 0, max: 1)]
            public string[] @DestinationPortRanges { get; }

            [nterraform.Core.TerraformProperty(name: "direction", @out: true, min: 0, max: 1)]
            public string @Direction { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
            public int? @Priority { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "source_address_prefix", @out: true, min: 0, max: 1)]
            public string @SourceAddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "source_address_prefixes", @out: true, min: 0, max: 1)]
            public string[] @SourceAddressPrefixes { get; }

            [nterraform.Core.TerraformProperty(name: "source_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SourceApplicationSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "source_port_range", @out: true, min: 0, max: 1)]
            public string @SourcePortRange { get; }

            [nterraform.Core.TerraformProperty(name: "source_port_ranges", @out: true, min: 0, max: 1)]
            public string[] @SourcePortRanges { get; }
        }

        public azurerm_network_security_group(string @name,
                                              string @resourceGroupName,
                                              security_rule[] @securityRule = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @SecurityRule = @securityRule;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "security_rule", @out: false, min: 0, max: 0)]
        public security_rule[] @SecurityRule { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
