using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_lb_probe")]
    public sealed class azurerm_lb_probe : nterraform.resource
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

        [nterraform.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "interval_in_seconds", @out: false, min: 0, max: 1)]
        public int? @IntervalInSeconds { get; }

        [nterraform.TerraformProperty(name: "load_balancer_rules", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancerRules { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "number_of_probes", @out: false, min: 0, max: 1)]
        public int? @NumberOfProbes { get; }

        [nterraform.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.TerraformProperty(name: "request_path", @out: false, min: 0, max: 1)]
        public string @RequestPath { get; }
    }

}
