using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_lb_nat_pool : NTerraform.resource
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
        }

        public int @BackendPort { get; }
        public string @FrontendIpConfigurationName { get; }
        public int @FrontendPortEnd { get; }
        public int @FrontendPortStart { get; }
        public string @LoadbalancerId { get; }
        public string @Name { get; }
        public string @Protocol { get; }
        public string @ResourceGroupName { get; }
        public string @FrontendIpConfigurationId { get; }
        public string @Location { get; }
    }

}
