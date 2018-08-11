using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_lb_backend_address_pool : NTerraform.resource
    {
        public azurerm_lb_backend_address_pool(string @loadbalancerId,
                                               string @name,
                                               string @resourceGroupName,
                                               string @location = null)
        {
            @LoadbalancerId = @loadbalancerId;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Location = @location;
        }

        public string @LoadbalancerId { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string[] @BackendIpConfigurations { get; }
        public string[] @LoadBalancingRules { get; }
        public string @Location { get; }
    }

}
