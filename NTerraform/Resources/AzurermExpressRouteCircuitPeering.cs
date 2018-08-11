using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_express_route_circuit_peering : NTerraform.resource
    {
        public sealed class microsoft_peering_config
        {
            public microsoft_peering_config(string[] @advertisedPublicPrefixes)
            {
                @AdvertisedPublicPrefixes = @advertisedPublicPrefixes;
            }

            public string[] @AdvertisedPublicPrefixes { get; }
        }

        public azurerm_express_route_circuit_peering(string @expressRouteCircuitName,
                                                     string @peeringType,
                                                     string @primaryPeerAddressPrefix,
                                                     string @resourceGroupName,
                                                     string @secondaryPeerAddressPrefix,
                                                     int @vlanId,
                                                     microsoft_peering_config[] @microsoftPeeringConfig = null,
                                                     string @sharedKey = null)
        {
            @ExpressRouteCircuitName = @expressRouteCircuitName;
            @PeeringType = @peeringType;
            @PrimaryPeerAddressPrefix = @primaryPeerAddressPrefix;
            @ResourceGroupName = @resourceGroupName;
            @SecondaryPeerAddressPrefix = @secondaryPeerAddressPrefix;
            @VlanId = @vlanId;
            @MicrosoftPeeringConfig = @microsoftPeeringConfig;
            @SharedKey = @sharedKey;
        }

        public string @ExpressRouteCircuitName { get; }
        public string @PeeringType { get; }
        public string @PrimaryPeerAddressPrefix { get; }
        public string @ResourceGroupName { get; }
        public string @SecondaryPeerAddressPrefix { get; }
        public int @VlanId { get; }
        public int? @AzureAsn { get; }
        public microsoft_peering_config[] @MicrosoftPeeringConfig { get; }
        public int? @PeerAsn { get; }
        public string @PrimaryAzurePort { get; }
        public string @SecondaryAzurePort { get; }
        public string @SharedKey { get; }
    }

}
