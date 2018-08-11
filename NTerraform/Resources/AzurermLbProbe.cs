using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_lb_probe : NTerraform.resource
    {
        public azurerm_lb_probe(string @loadbalancerId,
                                string @name,
                                int @port,
                                string @resourceGroupName,
                                int? @intervalInSeconds = null,
                                string @location = null,
                                int? @numberOfProbes = null,
                                string @requestPath = null)
        {
            @LoadbalancerId = @loadbalancerId;
            @Name = @name;
            @Port = @port;
            @ResourceGroupName = @resourceGroupName;
            @IntervalInSeconds = @intervalInSeconds;
            @Location = @location;
            @NumberOfProbes = @numberOfProbes;
            @RequestPath = @requestPath;
        }

        public string @LoadbalancerId { get; }
        public string @Name { get; }
        public int @Port { get; }
        public string @ResourceGroupName { get; }
        public int? @IntervalInSeconds { get; }
        public string[] @LoadBalancerRules { get; }
        public string @Location { get; }
        public int? @NumberOfProbes { get; }
        public string @Protocol { get; }
        public string @RequestPath { get; }
    }

}
