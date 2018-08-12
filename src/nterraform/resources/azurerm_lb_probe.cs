using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_lb_probe")]
    public sealed class azurerm_lb_probe : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "loadbalancer_id", @out: false, min: 1, max: 1)]
        public string @LoadbalancerId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
        public int @Port { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "interval_in_seconds", @out: false, min: 0, max: 1)]
        public int? @IntervalInSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancer_rules", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancerRules { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_probes", @out: false, min: 0, max: 1)]
        public int? @NumberOfProbes { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: true, min: 0, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "request_path", @out: false, min: 0, max: 1)]
        public string @RequestPath { get; }
    }

}
