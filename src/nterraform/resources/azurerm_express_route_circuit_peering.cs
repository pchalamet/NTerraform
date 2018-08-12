using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit_peering")]
    public sealed class azurerm_express_route_circuit_peering : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "microsoft_peering_config")]
        public sealed class microsoft_peering_config : nterraform.Core.structure
        {
            public microsoft_peering_config(string[] @advertisedPublicPrefixes)
            {
                @AdvertisedPublicPrefixes = @advertisedPublicPrefixes;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "advertised_public_prefixes", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "express_route_circuit_name", @out: false, min: 1, max: 1)]
        public string @ExpressRouteCircuitName { get; }

        [nterraform.Core.TerraformProperty(name: "peering_type", @out: false, min: 1, max: 1)]
        public string @PeeringType { get; }

        [nterraform.Core.TerraformProperty(name: "primary_peer_address_prefix", @out: false, min: 1, max: 1)]
        public string @PrimaryPeerAddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_peer_address_prefix", @out: false, min: 1, max: 1)]
        public string @SecondaryPeerAddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "vlan_id", @out: false, min: 1, max: 1)]
        public int @VlanId { get; }

        [nterraform.Core.TerraformProperty(name: "azure_asn", @out: true, min: 0, max: 1)]
        public int? @AzureAsn { get; }

        [nterraform.Core.TerraformProperty(name: "microsoft_peering_config", @out: false, min: 0, max: 1)]
        public microsoft_peering_config[] @MicrosoftPeeringConfig { get; }

        [nterraform.Core.TerraformProperty(name: "peer_asn", @out: true, min: 0, max: 1)]
        public int? @PeerAsn { get; }

        [nterraform.Core.TerraformProperty(name: "primary_azure_port", @out: true, min: 0, max: 1)]
        public string @PrimaryAzurePort { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_azure_port", @out: true, min: 0, max: 1)]
        public string @SecondaryAzurePort { get; }

        [nterraform.Core.TerraformProperty(name: "shared_key", @out: false, min: 0, max: 1)]
        public string @SharedKey { get; }
    }

}
