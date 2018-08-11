using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_lb_nat_rule")]
    public sealed class azurerm_lb_nat_rule : NTerraform.resource
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
        }

        [TerraformProperty(name: "backend_port", @out: false, nested: true, min: 1, max: 1)]
        public int @BackendPort { get; }

        [TerraformProperty(name: "frontend_ip_configuration_name", @out: false, nested: true, min: 1, max: 1)]
        public string @FrontendIpConfigurationName { get; }

        [TerraformProperty(name: "frontend_port", @out: false, nested: true, min: 1, max: 1)]
        public int @FrontendPort { get; }

        [TerraformProperty(name: "loadbalancer_id", @out: false, nested: true, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "protocol", @out: false, nested: true, min: 1, max: 1)]
        public string @Protocol { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "backend_ip_configuration_id", @out: true, nested: true, min: 0, max: 1)]
        public string @BackendIpConfigurationId { get; }

        [TerraformProperty(name: "enable_floating_ip", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableFloatingIp { get; }

        [TerraformProperty(name: "frontend_ip_configuration_id", @out: true, nested: true, min: 0, max: 1)]
        public string @FrontendIpConfigurationId { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 0, max: 1)]
        public string @Location { get; }
    }

}
