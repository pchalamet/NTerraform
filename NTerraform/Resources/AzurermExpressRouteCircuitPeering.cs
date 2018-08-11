using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit_peering")]
    public sealed class azurerm_express_route_circuit_peering : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "microsoft_peering_config")]
        public sealed class microsoft_peering_config
        {
            public microsoft_peering_config(string[] @advertisedPublicPrefixes)
            {
                @AdvertisedPublicPrefixes = @advertisedPublicPrefixes;
            }

            [TerraformProperty(name: "advertised_public_prefixes", @out: false, min: 1, max: 1)]
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

        [TerraformProperty(name: "express_route_circuit_name", @out: false, min: 1, max: 1)]
        public string @ExpressRouteCircuitName { get; }

        [TerraformProperty(name: "peering_type", @out: false, min: 1, max: 1)]
        public string @PeeringType { get; }

        [TerraformProperty(name: "primary_peer_address_prefix", @out: false, min: 1, max: 1)]
        public string @PrimaryPeerAddressPrefix { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "secondary_peer_address_prefix", @out: false, min: 1, max: 1)]
        public string @SecondaryPeerAddressPrefix { get; }

        [TerraformProperty(name: "vlan_id", @out: false, min: 1, max: 1)]
        public int @VlanId { get; }

        [TerraformProperty(name: "azure_asn", @out: true, min: 0, max: 1)]
        public int? @AzureAsn { get; }

        [TerraformProperty(name: "microsoft_peering_config", @out: false, min: 0, max: 1)]
        public microsoft_peering_config[] @MicrosoftPeeringConfig { get; }

        [TerraformProperty(name: "peer_asn", @out: true, min: 0, max: 1)]
        public int? @PeerAsn { get; }

        [TerraformProperty(name: "primary_azure_port", @out: true, min: 0, max: 1)]
        public string @PrimaryAzurePort { get; }

        [TerraformProperty(name: "secondary_azure_port", @out: true, min: 0, max: 1)]
        public string @SecondaryAzurePort { get; }

        [TerraformProperty(name: "shared_key", @out: false, min: 0, max: 1)]
        public string @SharedKey { get; }
    }

}
