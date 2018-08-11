using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_lb_probe")]
    public sealed class azurerm_lb_probe : NTerraform.resource
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
            base._validate_();
        }

        [TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "interval_in_seconds", @out: false, min: 0, max: 1)]
        public int? @IntervalInSeconds { get; }

        [TerraformProperty(name: "load_balancer_rules", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancerRules { get; }

        [TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "number_of_probes", @out: false, min: 0, max: 1)]
        public int? @NumberOfProbes { get; }

        [TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [TerraformProperty(name: "request_path", @out: false, min: 0, max: 1)]
        public string @RequestPath { get; }
    }

}
