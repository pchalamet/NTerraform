using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_local_network_gateway")]
    public sealed class azurerm_local_network_gateway : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "bgp_settings")]
        public sealed class bgp_settings
        {
            public bgp_settings(int @asn,
                                string @bgpPeeringAddress)
            {
                @Asn = @asn;
                @BgpPeeringAddress = @bgpPeeringAddress;
            }

            [TerraformProperty(name: "asn", @out: false, min: 1, max: 1)]
            public int @Asn { get; }

            [TerraformProperty(name: "bgp_peering_address", @out: false, min: 1, max: 1)]
            public string @BgpPeeringAddress { get; }

            [TerraformProperty(name: "peer_weight", @out: true, min: 0, max: 1)]
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
        }

        [TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
        public string[] @AddressSpace { get; }

        [TerraformProperty(name: "gateway_address", @out: false, min: 1, max: 1)]
        public string @GatewayAddress { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 1)]
        public bgp_settings[] @BgpSettings { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
