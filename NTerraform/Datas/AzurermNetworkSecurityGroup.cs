using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_network_security_group")]
    public sealed class azurerm_network_security_group : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "security_rule")]
        public sealed class security_rule: NTerraform.structure
        {
            public security_rule(string[] @destinationApplicationSecurityGroupIds = null,
                                 string[] @sourceApplicationSecurityGroupIds = null)
            {
                @DestinationApplicationSecurityGroupIds = @destinationApplicationSecurityGroupIds;
                @SourceApplicationSecurityGroupIds = @sourceApplicationSecurityGroupIds;
                base._validate_();
            }

            [TerraformProperty(name: "access", @out: true, min: 0, max: 1)]
            public string @Access { get; }

            [TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
            public string @Description { get; }

            [TerraformProperty(name: "destination_address_prefix", @out: true, min: 0, max: 1)]
            public string @DestinationAddressPrefix { get; }

            [TerraformProperty(name: "destination_address_prefixes", @out: true, min: 0, max: 1)]
            public string[] @DestinationAddressPrefixes { get; }

            [TerraformProperty(name: "destination_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @DestinationApplicationSecurityGroupIds { get; }

            [TerraformProperty(name: "destination_port_range", @out: true, min: 0, max: 1)]
            public string @DestinationPortRange { get; }

            [TerraformProperty(name: "destination_port_ranges", @out: true, min: 0, max: 1)]
            public string[] @DestinationPortRanges { get; }

            [TerraformProperty(name: "direction", @out: true, min: 0, max: 1)]
            public string @Direction { get; }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
            public int? @Priority { get; }

            [TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
            public string @Protocol { get; }

            [TerraformProperty(name: "source_address_prefix", @out: true, min: 0, max: 1)]
            public string @SourceAddressPrefix { get; }

            [TerraformProperty(name: "source_address_prefixes", @out: true, min: 0, max: 1)]
            public string[] @SourceAddressPrefixes { get; }

            [TerraformProperty(name: "source_application_security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SourceApplicationSecurityGroupIds { get; }

            [TerraformProperty(name: "source_port_range", @out: true, min: 0, max: 1)]
            public string @SourcePortRange { get; }

            [TerraformProperty(name: "source_port_ranges", @out: true, min: 0, max: 1)]
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "security_rule", @out: false, min: 0, max: 0)]
        public security_rule[] @SecurityRule { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
