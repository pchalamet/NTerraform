using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_network_security_group")]
    public sealed class azurerm_network_security_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "security_rule")]
        public sealed class security_rule : nterraform.Core.structure
        {
            public security_rule(string @access,
                                 string @direction,
                                 string @name,
                                 int @priority,
                                 string @protocol,
                                 FSharpOption<string> @description = null,
                                 FSharpOption<string> @destinationAddressPrefix = null,
                                 FSharpOption<FSharpList<string>> @destinationAddressPrefixes = null,
                                 FSharpOption<FSharpList<string>> @destinationApplicationSecurityGroupIds = null,
                                 FSharpOption<string> @destinationPortRange = null,
                                 FSharpOption<FSharpList<string>> @destinationPortRanges = null,
                                 FSharpOption<string> @sourceAddressPrefix = null,
                                 FSharpOption<FSharpList<string>> @sourceAddressPrefixes = null,
                                 FSharpOption<FSharpList<string>> @sourceApplicationSecurityGroupIds = null,
                                 FSharpOption<string> @sourcePortRange = null,
                                 FSharpOption<FSharpList<string>> @sourcePortRanges = null)
            {
                @Access = @access;
                @Direction = @direction;
                @Name = @name;
                @Priority = @priority;
                @Protocol = @protocol;
                @Description = @description;
                @DestinationAddressPrefix = @destinationAddressPrefix;
                @DestinationAddressPrefixes = @destinationAddressPrefixes ?? FSharpList<string>.Empty;
                @DestinationApplicationSecurityGroupIds = @destinationApplicationSecurityGroupIds ?? FSharpList<string>.Empty;
                @DestinationPortRange = @destinationPortRange;
                @DestinationPortRanges = @destinationPortRanges ?? FSharpList<string>.Empty;
                @SourceAddressPrefix = @sourceAddressPrefix;
                @SourceAddressPrefixes = @sourceAddressPrefixes ?? FSharpList<string>.Empty;
                @SourceApplicationSecurityGroupIds = @sourceApplicationSecurityGroupIds ?? FSharpList<string>.Empty;
                @SourcePortRange = @sourcePortRange;
                @SourcePortRanges = @sourcePortRanges ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "access", @out: false, min: 1, max: 1)]
            public string @Access { get; }

            [nterraform.Core.TerraformProperty(name: "direction", @out: false, min: 1, max: 1)]
            public string @Direction { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Description { get; }

            [nterraform.Core.TerraformProperty(name: "destination_address_prefix", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @DestinationAddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "destination_address_prefixes", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @DestinationAddressPrefixes { get; }

            [nterraform.Core.TerraformProperty(name: "destination_application_security_group_ids", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @DestinationApplicationSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "destination_port_range", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @DestinationPortRange { get; }

            [nterraform.Core.TerraformProperty(name: "destination_port_ranges", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @DestinationPortRanges { get; }

            [nterraform.Core.TerraformProperty(name: "source_address_prefix", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @SourceAddressPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "source_address_prefixes", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @SourceAddressPrefixes { get; }

            [nterraform.Core.TerraformProperty(name: "source_application_security_group_ids", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @SourceApplicationSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "source_port_range", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @SourcePortRange { get; }

            [nterraform.Core.TerraformProperty(name: "source_port_ranges", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @SourcePortRanges { get; }
        }

        public azurerm_network_security_group(string @location,
                                              string @name,
                                              string @resourceGroupName,
                                              FSharpOption<FSharpList<security_rule>> @securityRule = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @SecurityRule = @securityRule ?? FSharpList<security_rule>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "security_rule", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<security_rule>> @SecurityRule { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
