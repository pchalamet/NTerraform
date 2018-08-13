using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit")]
    public sealed class azurerm_express_route_circuit : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku(string @family,
                       string @tier)
            {
                @Family = @family;
                @Tier = @tier;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
            public string @Family { get; }

            [nterraform.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bandwidth_in_mbps", @out: false, min: 1, max: 1)]
        public int @BandwidthInMbps { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "peering_location", @out: false, min: 1, max: 1)]
        public string @PeeringLocation { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "service_provider_name", @out: false, min: 1, max: 1)]
        public string @ServiceProviderName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.TerraformProperty(name: "allow_classic_operations", @out: false, min: 0, max: 1)]
        public bool? @AllowClassicOperations { get; }

        [nterraform.TerraformProperty(name: "service_key", @out: true, min: 0, max: 1)]
        public string @ServiceKey { get; }

        [nterraform.TerraformProperty(name: "service_provider_provisioning_state", @out: true, min: 0, max: 1)]
        public string @ServiceProviderProvisioningState { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
