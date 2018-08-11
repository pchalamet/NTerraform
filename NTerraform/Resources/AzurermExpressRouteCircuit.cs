using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit")]
    public sealed class azurerm_express_route_circuit : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(string @family,
                       string @tier)
            {
                @Family = @family;
                @Tier = @tier;
            }

            [TerraformProperty(name: "family", @out: false, nested: false, min: 1, max: 1)]
            public string @Family { get; }

            [TerraformProperty(name: "tier", @out: false, nested: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        public azurerm_express_route_circuit(int @bandwidthInMbps,
                                             string @location,
                                             string @name,
                                             string @peeringLocation,
                                             string @resourceGroupName,
                                             string @serviceProviderName,
                                             sku[] @sku,
                                             bool? @allowClassicOperations = null)
        {
            @BandwidthInMbps = @bandwidthInMbps;
            @Location = @location;
            @Name = @name;
            @PeeringLocation = @peeringLocation;
            @ResourceGroupName = @resourceGroupName;
            @ServiceProviderName = @serviceProviderName;
            @Sku = @sku;
            @AllowClassicOperations = @allowClassicOperations;
        }

        [TerraformProperty(name: "bandwidth_in_mbps", @out: false, nested: true, min: 1, max: 1)]
        public int @BandwidthInMbps { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "peering_location", @out: false, nested: true, min: 1, max: 1)]
        public string @PeeringLocation { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "service_provider_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ServiceProviderName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "allow_classic_operations", @out: false, nested: true, min: 0, max: 1)]
        public bool? @AllowClassicOperations { get; }

        [TerraformProperty(name: "service_key", @out: true, nested: true, min: 0, max: 1)]
        public string @ServiceKey { get; }

        [TerraformProperty(name: "service_provider_provisioning_state", @out: true, nested: true, min: 0, max: 1)]
        public string @ServiceProviderProvisioningState { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
