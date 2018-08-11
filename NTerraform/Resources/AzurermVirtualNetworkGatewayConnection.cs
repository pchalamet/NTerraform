using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_network_gateway_connection : NTerraform.resource
    {
        public class ipsec_policy
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

            public string @DhGroup { get; }
            public string @IkeEncryption { get; }
            public string @IkeIntegrity { get; }
            public string @IpsecEncryption { get; }
            public string @IpsecIntegrity { get; }
            public string @PfsGroup { get; }
            public int? @SaDatasize { get; }
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

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Type { get; }
        public string @VirtualNetworkGatewayId { get; }
        public string @AuthorizationKey { get; }
        public bool? @EnableBgp { get; }
        public string @ExpressRouteCircuitId { get; }
        public ipsec_policy[] @IpsecPolicy { get; }
        public string @LocalNetworkGatewayId { get; }
        public string @PeerVirtualNetworkGatewayId { get; }
        public int? @RoutingWeight { get; }
        public string @SharedKey { get; }
        public Dictionary<string,string> @Tags { get; }
        public bool? @UsePolicyBasedTrafficSelectors { get; }
    }

}
