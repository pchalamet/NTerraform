using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_lb_nat_rule")]
    public sealed class azurerm_lb_nat_rule : nterraform.Core.resource
    {
        public azurerm_lb_nat_rule(int @backendPort,
                                   string @frontendIpConfigurationName,
                                   int @frontendPort,
                                   string @loadbalancerId,
                                   string @name,
                                   string @protocol,
                                   string @resourceGroupName,
                                   FSharpOption<string> @location = null)
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

        [nterraform.Core.TerraformProperty(name: "backend_port", @out: false, min: 1, max: 1)]
        public int @BackendPort { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_ip_configuration_name", @out: false, min: 1, max: 1)]
        public string @FrontendIpConfigurationName { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_port", @out: false, min: 1, max: 1)]
        public int @FrontendPort { get; }

        [nterraform.Core.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "backend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @BackendIpConfigurationId { get; }

        [nterraform.Core.TerraformProperty(name: "enable_floating_ip", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableFloatingIp { get; }

        [nterraform.Core.TerraformProperty(name: "frontend_ip_configuration_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @FrontendIpConfigurationId { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }
    }

}
