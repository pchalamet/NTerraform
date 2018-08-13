using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_lb_nat_rule")]
    public sealed class azurerm_lb_nat_rule : nterraform.resource
    {
        public azurerm_lb_nat_rule(int @backendPort,
                                   string @frontendIpConfigurationName,
                                   int @frontendPort,
                                   string @loadbalancerId,
                                   string @name,
                                   string @protocol,
                                   string @resourceGroupName,
                                   string @location = null)
        {
            @BackendPort = @backendPort;
            @FrontendIpConfigurationName = @frontendIpConfigurationName;
            @FrontendPort = @frontendPort;
            @LoadbalancerId = @loadbalancerId;
            @Name = @name;
            @Protocol = @protocol;
            @ResourceGroupName = @resourceGroupName;
            @Location = @location;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "backend_port", @out: false, min: 1, max: 1)]
        public int @BackendPort { get; }

        [nterraform.TerraformProperty(name: "frontend_ip_configuration_name", @out: false, min: 1, max: 1)]
        public string @FrontendIpConfigurationName { get; }

        [nterraform.TerraformProperty(name: "frontend_port", @out: false, min: 1, max: 1)]
        public int @FrontendPort { get; }

        [nterraform.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "backend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public string @BackendIpConfigurationId { get; }

        [nterraform.TerraformProperty(name: "enable_floating_ip", @out: true, min: 0, max: 1)]
        public bool? @EnableFloatingIp { get; }

        [nterraform.TerraformProperty(name: "frontend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public string @FrontendIpConfigurationId { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }
    }

}
