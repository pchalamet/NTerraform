using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_gateway_connection")]
    public sealed class azurerm_virtual_network_gateway_connection : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "ipsec_policy")]
        public sealed class ipsec_policy
        {
            public ipsec_policy(string @dhGroup,
                                string @ikeEncryption,
                                string @ikeIntegrity,
                                string @ipsecEncryption,
                                string @ipsecIntegrity,
                                string @pfsGroup)
            {
                @DhGroup = @dhGroup;
                @IkeEncryption = @ikeEncryption;
                @IkeIntegrity = @ikeIntegrity;
                @IpsecEncryption = @ipsecEncryption;
                @IpsecIntegrity = @ipsecIntegrity;
                @PfsGroup = @pfsGroup;
            }

            [TerraformProperty(name: "dh_group", @out: false, nested: false, min: 1, max: 1)]
            public string @DhGroup { get; }

            [TerraformProperty(name: "ike_encryption", @out: false, nested: false, min: 1, max: 1)]
            public string @IkeEncryption { get; }

            [TerraformProperty(name: "ike_integrity", @out: false, nested: false, min: 1, max: 1)]
            public string @IkeIntegrity { get; }

            [TerraformProperty(name: "ipsec_encryption", @out: false, nested: false, min: 1, max: 1)]
            public string @IpsecEncryption { get; }

            [TerraformProperty(name: "ipsec_integrity", @out: false, nested: false, min: 1, max: 1)]
            public string @IpsecIntegrity { get; }

            [TerraformProperty(name: "pfs_group", @out: false, nested: false, min: 1, max: 1)]
            public string @PfsGroup { get; }

            [TerraformProperty(name: "sa_datasize", @out: true, nested: false, min: 0, max: 1)]
            public int? @SaDatasize { get; }

            [TerraformProperty(name: "sa_lifetime", @out: true, nested: false, min: 0, max: 1)]
            public int? @SaLifetime { get; }
        }

        public azurerm_virtual_network_gateway_connection(string @location,
                                                          string @name,
                                                          string @resourceGroupName,
                                                          string @type,
                                                          string @virtualNetworkGatewayId,
                                                          string @authorizationKey = null,
                                                          string @expressRouteCircuitId = null,
                                                          ipsec_policy[] @ipsecPolicy = null,
                                                          string @localNetworkGatewayId = null,
                                                          string @peerVirtualNetworkGatewayId = null,
                                                          string @sharedKey = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Type = @type;
            @VirtualNetworkGatewayId = @virtualNetworkGatewayId;
            @AuthorizationKey = @authorizationKey;
            @ExpressRouteCircuitId = @expressRouteCircuitId;
            @IpsecPolicy = @ipsecPolicy;
            @LocalNetworkGatewayId = @localNetworkGatewayId;
            @PeerVirtualNetworkGatewayId = @peerVirtualNetworkGatewayId;
            @SharedKey = @sharedKey;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "type", @out: false, nested: true, min: 1, max: 1)]
        public string @Type { get; }

        [TerraformProperty(name: "virtual_network_gateway_id", @out: false, nested: true, min: 1, max: 1)]
        public string @VirtualNetworkGatewayId { get; }

        [TerraformProperty(name: "authorization_key", @out: false, nested: true, min: 0, max: 1)]
        public string @AuthorizationKey { get; }

        [TerraformProperty(name: "enable_bgp", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [TerraformProperty(name: "express_route_circuit_id", @out: false, nested: true, min: 0, max: 1)]
        public string @ExpressRouteCircuitId { get; }

        [TerraformProperty(name: "ipsec_policy", @out: false, nested: true, min: 0, max: 1)]
        public ipsec_policy[] @IpsecPolicy { get; }

        [TerraformProperty(name: "local_network_gateway_id", @out: false, nested: true, min: 0, max: 1)]
        public string @LocalNetworkGatewayId { get; }

        [TerraformProperty(name: "peer_virtual_network_gateway_id", @out: false, nested: true, min: 0, max: 1)]
        public string @PeerVirtualNetworkGatewayId { get; }

        [TerraformProperty(name: "routing_weight", @out: true, nested: true, min: 0, max: 1)]
        public int? @RoutingWeight { get; }

        [TerraformProperty(name: "shared_key", @out: false, nested: true, min: 0, max: 1)]
        public string @SharedKey { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "use_policy_based_traffic_selectors", @out: true, nested: true, min: 0, max: 1)]
        public bool? @UsePolicyBasedTrafficSelectors { get; }
    }

}
