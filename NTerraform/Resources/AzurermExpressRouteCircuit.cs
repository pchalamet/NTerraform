using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_express_route_circuit : NTerraform.resource
    {
        public class sku
        {
            public sku(string @family,
                       string @tier)
            {
                @Family = @family;
                @Tier = @tier;
            }

            public string @Family { get; }
            public string @Tier { get; }
        }

        public azurerm_express_route_circuit(int @bandwidthInMbps,
                                             string @location,
                                             string @name,
                                             string @peeringLocation,
                                             string @resourceGroupName,
                                             string @serviceProviderName,
                                             List<sku> @sku,
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

        public int @BandwidthInMbps { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @PeeringLocation { get; }
        public string @ResourceGroupName { get; }
        public string @ServiceProviderName { get; }
        public List<sku> @Sku { get; }
        public bool? @AllowClassicOperations { get; }
        public string @ServiceKey { get; }
        public string @ServiceProviderProvisioningState { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
