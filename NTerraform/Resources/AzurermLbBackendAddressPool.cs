using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_lb_backend_address_pool")]
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

        [TerraformProperty(name: "loadbalancer_id", @out: false, nested: true, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "backend_ip_configurations", @out: true, nested: true, min: 0, max: 1)]
        public string[] @BackendIpConfigurations { get; }

        [TerraformProperty(name: "load_balancing_rules", @out: true, nested: true, min: 0, max: 1)]
        public string[] @LoadBalancingRules { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 0, max: 1)]
        public string @Location { get; }
    }

}
