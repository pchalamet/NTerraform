using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_lb_nat_pool")]
    public sealed class azurerm_lb_nat_pool : nterraform.Core.resource
    {
        public azurerm_lb_nat_pool(int @backendPort,
                                   string @frontendIpConfigurationName,
                                   int @frontendPortEnd,
                                   int @frontendPortStart,
                                   string @loadbalancerId,
                                   string @name,
                                   string @protocol,
                                   string @resourceGroupName,
                                   string @location = null)
        {
            @BackendPort = @backendPort;
            @FrontendIpConfigurationName = @frontendIpConfigurationName;
            @FrontendPortEnd = @frontendPortEnd;
            @FrontendPortStart = @frontendPortStart;
            @LoadbalancerId = @loadbalancerId;
            @Name = @name;
            @Protocol = @protocol;
            @ResourceGroupName = @resourceGroupName;
            @Location = @location;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "backend_port", @out: false, min: 1, max: 1)]
        public int @BackendPort { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_ip_configuration_name", @out: false, min: 1, max: 1)]
        public string @FrontendIpConfigurationName { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_port_end", @out: false, min: 1, max: 1)]
        public int @FrontendPortEnd { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_port_start", @out: false, min: 1, max: 1)]
        public int @FrontendPortStart { get; }

        [nterraform.Core.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public string @FrontendIpConfigurationId { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }
    }

}
