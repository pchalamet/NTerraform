using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_lb_backend_address_pool")]
    public sealed class azurerm_lb_backend_address_pool : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "backend_ip_configurations", @out: true, min: 0, max: 1)]
        public string[] @BackendIpConfigurations { get; }

        [nterraform.TerraformProperty(name: "load_balancing_rules", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancingRules { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }
    }

}
