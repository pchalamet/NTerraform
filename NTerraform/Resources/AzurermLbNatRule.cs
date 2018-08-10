using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_lb_nat_rule : NTerraform.resource
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

        public int @BackendPort { get; }
        public string @FrontendIpConfigurationName { get; }
        public int @FrontendPort { get; }
        public string @LoadbalancerId { get; }
        public string @Name { get; }
        public string @Protocol { get; }
        public string @ResourceGroupName { get; }
        public string @BackendIpConfigurationId { get; }
        public bool? @EnableFloatingIp { get; }
        public string @FrontendIpConfigurationId { get; }
        public string @Location { get; }
    }

}
