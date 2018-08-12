using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_gateway_connection")]
    public sealed class azurerm_virtual_network_gateway_connection : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ipsec_policy")]
        public sealed class ipsec_policy : nterraform.Core.structure
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
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dh_group", @out: false, min: 1, max: 1)]
            public string @DhGroup { get; }

            [nterraform.Core.TerraformProperty(name: "ike_encryption", @out: false, min: 1, max: 1)]
            public string @IkeEncryption { get; }

            [nterraform.Core.TerraformProperty(name: "ike_integrity", @out: false, min: 1, max: 1)]
            public string @IkeIntegrity { get; }

            [nterraform.Core.TerraformProperty(name: "ipsec_encryption", @out: false, min: 1, max: 1)]
            public string @IpsecEncryption { get; }

            [nterraform.Core.TerraformProperty(name: "ipsec_integrity", @out: false, min: 1, max: 1)]
            public string @IpsecIntegrity { get; }

            [nterraform.Core.TerraformProperty(name: "pfs_group", @out: false, min: 1, max: 1)]
            public string @PfsGroup { get; }

            [nterraform.Core.TerraformProperty(name: "sa_datasize", @out: true, min: 0, max: 1)]
            public int? @SaDatasize { get; }

            [nterraform.Core.TerraformProperty(name: "sa_lifetime", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_network_gateway_id", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "authorization_key", @out: false, min: 0, max: 1)]
        public string @AuthorizationKey { get; }

        [nterraform.Core.TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [nterraform.Core.TerraformProperty(name: "express_route_circuit_id", @out: false, min: 0, max: 1)]
        public string @ExpressRouteCircuitId { get; }

        [nterraform.Core.TerraformProperty(name: "ipsec_policy", @out: false, min: 0, max: 1)]
        public ipsec_policy[] @IpsecPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "local_network_gateway_id", @out: false, min: 0, max: 1)]
        public string @LocalNetworkGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "peer_virtual_network_gateway_id", @out: false, min: 0, max: 1)]
        public string @PeerVirtualNetworkGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "routing_weight", @out: true, min: 0, max: 1)]
        public int? @RoutingWeight { get; }

        [nterraform.Core.TerraformProperty(name: "shared_key", @out: false, min: 0, max: 1)]
        public string @SharedKey { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "use_policy_based_traffic_selectors", @out: true, min: 0, max: 1)]
        public bool? @UsePolicyBasedTrafficSelectors { get; }
    }

}