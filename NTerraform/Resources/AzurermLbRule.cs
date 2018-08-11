using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_lb_rule")]
    public sealed class azurerm_lb_rule : NTerraform.resource
    {
        public azurerm_lb_rule(int @backendPort,
                               string @frontendIpConfigurationName,
                               int @frontendPort,
                               string @loadbalancerId,
                               string @name,
                               string @protocol,
                               string @resourceGroupName,
                               bool? @enableFloatingIp = null,
                               string @location = null)
        {
            @BackendPort = @backendPort;
            @FrontendIpConfigurationName = @frontendIpConfigurationName;
            @FrontendPort = @frontendPort;
            @LoadbalancerId = @loadbalancerId;
            @Name = @name;
            @Protocol = @protocol;
            @ResourceGroupName = @resourceGroupName;
            @EnableFloatingIp = @enableFloatingIp;
            @Location = @location;
            base._validate_();
        }

        [TerraformProperty(name: "backend_port", @out: false, min: 1, max: 1)]
        public int @BackendPort { get; }

        [TerraformProperty(name: "frontend_ip_configuration_name", @out: false, min: 1, max: 1)]
        public string @FrontendIpConfigurationName { get; }

        [TerraformProperty(name: "frontend_port", @out: false, min: 1, max: 1)]
        public int @FrontendPort { get; }

        [TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "backend_address_pool_id", @out: true, min: 0, max: 1)]
        public string @BackendAddressPoolId { get; }

        [TerraformProperty(name: "enable_floating_ip", @out: false, min: 0, max: 1)]
        public bool? @EnableFloatingIp { get; }

        [TerraformProperty(name: "frontend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public string @FrontendIpConfigurationId { get; }

        [TerraformProperty(name: "idle_timeout_in_minutes", @out: true, min: 0, max: 1)]
        public int? @IdleTimeoutInMinutes { get; }

        [TerraformProperty(name: "load_distribution", @out: true, min: 0, max: 1)]
        public string @LoadDistribution { get; }

        [TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "probe_id", @out: true, min: 0, max: 1)]
        public string @ProbeId { get; }
    }

}
