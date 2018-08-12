using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_local_network_gateway")]
    public sealed class azurerm_local_network_gateway : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "bgp_settings")]
        public sealed class bgp_settings : nterraform.Core.structure
        {
            public bgp_settings(int @asn,
                                string @bgpPeeringAddress)
            {
                @Asn = @asn;
                @BgpPeeringAddress = @bgpPeeringAddress;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "asn", @out: false, min: 1, max: 1)]
            public int @Asn { get; }

            [nterraform.Core.TerraformProperty(name: "bgp_peering_address", @out: false, min: 1, max: 1)]
            public string @BgpPeeringAddress { get; }

            [nterraform.Core.TerraformProperty(name: "peer_weight", @out: true, min: 0, max: 1)]
            public int? @PeerWeight { get; }
        }

        public azurerm_local_network_gateway(string[] @addressSpace,
                                             string @gatewayAddress,
                                             string @location,
                                             string @name,
                                             string @resourceGroupName,
                                             bgp_settings[] @bgpSettings = null)
        {
            @AddressSpace = @addressSpace;
            @GatewayAddress = @gatewayAddress;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @BgpSettings = @bgpSettings;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
        public string[] @AddressSpace { get; }

        [nterraform.Core.TerraformProperty(name: "gateway_address", @out: false, min: 1, max: 1)]
        public string @GatewayAddress { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 1)]
        public bgp_settings[] @BgpSettings { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}